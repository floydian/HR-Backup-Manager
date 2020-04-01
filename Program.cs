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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Backup_Manager
{
    public partial class WF
    {
        public Program program;
        public MainForm mainForm;
        public Settings settings;
        public BackupData backupData;
    }

    public class Program : ApplicationContext
    {

        protected WF wf;
        public bool CloseMainForm = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            WF wf = WF.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Program();
            Application.Run(wf.program);
        }

        public Program()
        {
            wf = WF.Instance;
            wf.program = this;
            new Settings();
            new MainForm();

            if (CloseMainForm)
            {
                List<Control> controls = new List<Control>();
                foreach (Control control in wf.mainForm.Controls)
                {
                    controls.Add(control);
                }
                foreach (Control control in controls)
                {
                    wf.mainForm.Controls.Remove(control);
                }
                wf.mainForm.Closed += new EventHandler(this.OnFormClosed);
                wf.mainForm.Show();

                return;
            }

            new BackupData();

            wf.logs.Add("foo1");
            wf.logs.Add("foo2");


            wf.mainForm.Closed += new EventHandler(this.OnFormClosed);
            wf.mainForm.Show();
            //wf.mainForm.appMsgLabel.Text = "Testing single and \"double\" quotes.";
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            ExitThread();
        }
    }
}
