using System;
using System.Configuration;  
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Specialized;

namespace wf_Backup_Manager {
	
	public partial class WF {
		public Program program;
		public MainForm mainForm;
		public Settings settings;
		public BackupSettings backupSettings;
		public SettingsView settingsView;
	}
	
	public class Program : ApplicationContext {
		
		protected WF wf;
		
		[STAThread]
		public static void Main() {
			WF wf = WF.Instance;
			wf.program = new Program();
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(wf.program);
		}
		
		public Program() {
			wf = WF.Instance;
			try {
				wf.settings = new Settings();
				
				wf.mainForm = new MainForm();
				wf.mainForm.Closed += new EventHandler(this.OnFormClosed);
				
				wf.backupSettings = new BackupSettings();
				wf.settingsView = new SettingsView();
				
				wf.mainForm.Show();
			} catch (Exception ex){
				MessageBox.Show(ex.ToString());
				//ExitThread();
			}
			//wf.mainForm.appMsgLabel.Text = "Testing single and \"double\" quotes.";
		}
		
		private void OnFormClosed(object sender, EventArgs e) {
			 ExitThread();
		}
	}
}










