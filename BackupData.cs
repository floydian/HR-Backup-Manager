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
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace HR_Backup_Manager
{
    public class BackupData
    {

        private readonly WF wf = WF.Instance;

        private Dictionary<string, Setlist> setlists;
        private Dictionary<string, Rig> rigs;


        public BackupData()
        {
            wf.backupData = this;
            ResetBackupData();
        }

        // Rig Json data
        // IR path: string IR children IR children Patch data
        // data Patch children IR children Ir string

        public void ResetBackupData()
        {
            setlists = new Dictionary<string, Setlist>();
            rigs = new Dictionary<string, Rig>();

            try
            {
                InitializeRigData();
                InitializeSetListData();
            }
            catch (Exception e)
            {
               // wf.mainForm.SetProgramMessageBoxText(e.Message);
            }

            wf.mainForm.InitializeBrowseTreeView(setlists);
            wf.mainForm.SelectSearchRadioRigButton();
        }

        private void InitializeRigData()
        {
            string[] rigFiles = Directory.GetFiles(Properties.Settings.Default.BackupDir + @"\Rigs");
            foreach (string rigFilePath in rigFiles)
            {
                Rig rig = JSON.Read<Rig>(File.ReadAllText(rigFilePath));
                string filename = Path.GetFileName(rigFilePath);
                rig.name = rig.key = filename.Substring(0, filename.Length - 4);

                rig.contentData = JSON.ReadLinq(rig.content);
                try
                {
                    rig.IR = (string)rig.contentData["data"]["Patch"]["children"]["IR"]["children"]["IR"]["string"];
                    rig.hasIR = true;
                }
                catch (System.NullReferenceException)
                {
                    rig.hasIR = false;
                }

                rigs.Add(rig.key, rig);
            }
        }

        private void InitializeSetListData()
        {
            string[] setlistFiles = Directory.GetFiles(Properties.Settings.Default.BackupDir + @"\Setlists");
            foreach (string setlistFilePath in setlistFiles)
            {
                Setlist setlist = JSON.Read<Setlist>(File.ReadAllText(setlistFilePath));
                string filename = Path.GetFileName(setlistFilePath);
                setlist.name = setlist.key = filename.Substring(0, filename.Length - 8);
                setlists.Add(setlist.key, setlist);
                foreach (Song song in setlist.songs)
                {
                    song.rig_names = song.rig_names.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    song.setlist = setlist;
                    foreach (string rig_name in song.rig_names)
                    {
                        try
                        {
                            Rig rig = rigs[rig_name];
                            rig.links.setlists.Add(setlist);
                            rig.links.songs.Add(song);
                            song.rigsList.Add(rig);
                            rig.inSetlist = true;
                        }
                        catch (KeyNotFoundException)
                        {
                        }

                    }
                    
                }
            }
        }

        public Dictionary<string, Setlist> GetSetlists()
        {
            return setlists;
        }

        public Dictionary<string, Setlist>.ValueCollection GetSetlistsValues()
        {
            return setlists.Values;
        }

        public string GetSetlistNames()
        {
            string setlistNames = "";
            foreach (KeyValuePair<string, Setlist> setlist in setlists)
            {
                setlistNames += setlist.Key + "\r\n";
            }
            if (setlistNames.Length > 2)
            {
                setlistNames = setlistNames.Substring(0, setlistNames.Length-2);
            }
            return setlistNames;
        }

        public Setlist GetSetlistByName(string name)
        {
            return setlists[name];
        }

        // "Key" here is the all capitalized name of the rig.
        // So this is really a SearchRigsByName method.
        public List<Rig> SearchRigsByKey(string key)
        {
            List<Rig> results = new List<Rig>();
            foreach (KeyValuePair<string, Rig> rig in rigs)
            {
                if (rig.Value.key.Contains(key.ToUpper()))
                {
                    results.Add(rig.Value);
                }
            }
            return results;
        }

        public List<Rig> SearchRigsByIR(string ir)
        {
            List<Rig> results = new List<Rig>();
            foreach (KeyValuePair<string, Rig> pair in rigs)
            {
                Rig rig = pair.Value;
                if (rig.hasIR && rig.IR.ToUpper().Contains(ir.ToUpper()))
                {
                    results.Add(rig);
                }
            }
            return results;
        }

        public Rig GetRigByKey(string key)
        {
            return rigs[key.ToUpper()];
        }

    }
}
