/* HeadRush Backup Manager
 * Author: Wayne Fincher
 * Version: Beta 1.0
 * License: Public Domain
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Configuration;  
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace HR_Backup_Manager
{
	
	public class Settings {

        /*
         * Only used to compare to Properties.Settings.Default settings
         * to see if any changes to the settings has been made.
         */
        private readonly Dictionary<string, string> settings = new Dictionary<string, string>();
        
        private readonly WF wf = WF.Instance;

        public String errorMessage = "";
        private readonly String[] backupSubFolderList = { "Blocks", "Impulse Responses", "Loops", "Rigs", "Setlists" };

        public Settings() {
            wf.settings = this;

            if (Properties.Settings.Default.AllCaps != "No" && Properties.Settings.Default.AllCaps != "Yes")
            {
                Properties.Settings.Default.AllCaps = "Yes";
            }

            foreach (SettingsProperty item in Properties.Settings.Default.Properties)
            {
                settings.Add(item.Name, (string) Properties.Settings.Default[item.Name]);
            }

            if (Properties.Settings.Default.License == "")
            {
                string text = "Thank you for using the HeadRush Backup Manager.\r\n" +
                    "Before proceeding, please either accept or decline the following terms of use.\r\n\r\n" +
                    "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND,\r\n" +
                    "EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF\r\n" +
                    "MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND\r\n" +
                    "NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE\r\n" +
                    "LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION\r\n" +
                    "OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION\r\n" +
                    "WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.\r\n";
                string caption = "Terms of Use";
                if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    wf.program.CloseMainForm = true;


                }
                else
                {
                    Properties.Settings.Default.License = "Accepted";
                    Save();
                }
            }
        }
		
		/*
			Compare appSettings with savedAppSettings to see if any settings have been changed
			and hence if the settings need to be saved.
		*/
		public bool Changed()
        {
            foreach (SettingsProperty item in Properties.Settings.Default.Properties)
            {
                if (settings[item.Name] != (string)Properties.Settings.Default[item.Name])
                {
                    return true;
                }
            }
            return false;
        }

        public void Save()
        {
            if (Changed())
            {
                Properties.Settings.Default.Save();
                CopySettings();
                //Properties.Settings.Default.Reload();
            }
        }

        protected void CopySettings()
        {
            foreach (SettingsProperty item in Properties.Settings.Default.Properties)
            {
                settings[item.Name] = (string)Properties.Settings.Default[item.Name];
            }
        }

        /*
         * Has exceptions...
         */
        public bool IsValidBackupFolder(String selectedPath)
        {
            String[] folders;
            try
            {
                folders = Directory.GetDirectories(selectedPath);
            }
            catch (Exception)
            {
                //errorMessage = String.Format("Validating a folder as a valid backup folder failed: {0}", e.ToString());
                return false;
            }

            String[] folderNames = new String[folders.Length];
            for (int i = 0; i < folders.Length; i++)
            {
                folderNames[i] = folders[i].Remove(0, selectedPath.Length + 1);
            }

            int count = 0;
            foreach (string folderName1 in folderNames)
            {
                foreach (string folderName2 in backupSubFolderList)
                {
                    if (folderName1 == folderName2)
                    {
                        count++;
                    }
                }
            }
            //wf.mainForm.SetProgramMessageBoxText((count == backupSubFolderList.Length).ToString());

            /*
            for (int i = 0; i < folderNames.Length; i++)
            {
                for (int j = 0; j < backupSubFolderList.Length; j++)
                {
                    if (folderNames[i] == backupSubFolderList[j])
                    {
                        count++;
                    }
                };
            }
            */

            if (count == backupSubFolderList.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
	
}