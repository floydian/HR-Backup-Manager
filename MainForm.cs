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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Backup_Manager
{
    public partial class MainForm : Form
    {
        private readonly WF wf;

        private readonly Font fontRegular = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
        private readonly Font fontHeading = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold);

        public MainForm()
        {
            wf = WF.Instance;
            wf.mainForm = this;


            if (wf.program.CloseMainForm)
            {
                return;
            }

            InitializeComponent();
            SettingsResultLabel.Text = "";
            BrowseTreeCurrentNodeLabel.Text = "";
            BackupDirTextBox.Text = Properties.Settings.Default.BackupDir;
            SetAllFonts();

            if (Properties.Settings.Default.AllCaps == "Yes")
            {
                AllCapsYes.Checked = true;
            }
            else
            {
                AllCapsNo.Checked = true;
            }
            richTextBox1.BackColor = Color.White;
            richTextBox1.Rtf = Properties.Resources.GettingStarted;
            AllCapsToolTip.SetToolTip(AllCapsLabel, "Determines whether or not setlists, songs, and rigs are displayed in all caps.");
            RigSearchResultsListView.Columns.Add("rig", "Rig", 200);
            RigSearchResultsListView.Columns.Add("ir", "IR", 300);
            RigDataNameLabel2.Text = "";
            RigDataIRLabel2.Text = "";
            BackupFolderErrorLabel.Text = "";
        }

        public void InitializeBrowseTreeView(Dictionary<string, Setlist> setlists)
        {
            BrowseTreeView.Nodes.Clear();
            foreach (KeyValuePair<string, Setlist> setlist in setlists)
            {
                TreeNode node = BrowseTreeView.Nodes.Add(setlist.Value.key, setlist.Value.name);
                node.ToolTipText = setlist.Value.name + " setlist";
                foreach (Song song in setlist.Value.songs)
                {
                    TreeNode subnode = node.Nodes.Add(song.key, song.song_name);
                    subnode.ToolTipText = song.song_name + " song";

                    foreach (Rig rig in song.rigsList)
                    {
                        TreeNode subsubnode = subnode.Nodes.Add(rig.key, rig.name);
                        subsubnode.ToolTipText = rig.name + " rig";
                        subsubnode.Tag = rig;
                    }
                }
            }
        }

        private void ResetBackUpDataTab()
        {
            TreeNode selectedNode = BrowseTreeView.SelectedNode;
            InitializeBrowseTreeView(wf.backupData.GetSetlists());

            if (selectedNode != null)
            {
                foreach (TreeNode node in BrowseTreeView.GetAllNodes())
                {
                    if (node.Level == selectedNode.Level && node.Name == selectedNode.Name)
                    {
                        BrowseTreeView.SelectedNode = node;
                        node.Expand();
                        break;
                    }
                }
            }
        }

        private void SetAllFonts()
        {
            MainTabControl.Font = fontHeading;
            SettingsTab.Font = fontRegular;
            BrowseTab.Font = fontRegular;
        }

        public void SetProgramMessageBoxText(string text)
        {
            ProgramMessageBox.Text += text;
        }

        private void EnableSaveButtonIfNeeded()
        {
            SettingsSaveButton.Enabled = wf.settings.Changed();
            SettingsResultLabel.Text = "";
        }

        private void BakupDirSubmenuButton_Click(object sender, EventArgs e)
        {
            if (BackupDirBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                if (!wf.settings.IsValidBackupFolder(BackupDirBrowserDialog.SelectedPath))
                {
                    BackupFolderErrorLabel.Text = "Not a valid backup. Try again.";
                } else
                {

                    BackupFolderErrorLabel.Text = "";
                    BackupDirTextBox.Text = BackupDirBrowserDialog.SelectedPath;
                    Properties.Settings.Default.BackupDir = BackupDirBrowserDialog.SelectedPath;

                    // We win! The backup folder was successfully selected.
                    EnableSaveButtonIfNeeded();
                }
            }
        }

        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            wf.settings.Save();
            SettingsSaveButton.Enabled = false;

            // Call these two functions if the backup folder was not changed.
            //ResetBackUpDataTab();
            //UpdateRigSearchResultsListView();


            wf.backupData.ResetBackupData();
            SettingsResultLabel.Text = "Settings have been saved.";
        }

        private void FontNameTextBox_Enter(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                //FontNameTextBox.Text = fontDialog.Font.Name;
               // FontSizeSpinner.Value = (int)Math.Round(fontDialog.Font.Size);
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AllCaps = "Yes";
            EnableSaveButtonIfNeeded();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AllCaps = "No";
            EnableSaveButtonIfNeeded();
        }

        private void RigSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateRigSearchResultsListView();
        }

        public void UpdateRigSearchResultsListView()
        {
            List<Rig> rigs;
            if (searchType == SearchTypeEnum.Rig || RigSearchTextBox.Text == "")
            {
                rigs = wf.backupData.SearchRigsByKey(RigSearchTextBox.Text);
            }
            else
            {
                rigs = wf.backupData.SearchRigsByIR(RigSearchTextBox.Text);
            }
            RigSearchResultsListView.Items.Clear();
            if (rigs.Count == 0)
            {
                RigSearchResultsListView.Items.Add("No matches found...");
            }
            else
            {
                foreach (Rig rig in rigs)
                {
                    if ( (OnlyIRButtonState && !rig.hasIR) || (OnlyRigsButtonState && rig.inSetlist) )
                    {
                        continue;
                    }
                    ListViewItem listViewItem = new ListViewItem(new string[] { rig.name, rig.hasIR ? rig.IR : "no IR" });
                    RigSearchResultsListView.Items.Add(listViewItem);
                    listViewItem.Tag = rig;
                }
            }
        }

        public void SelectSearchRadioRigButton()
        {
            SearchRadioRigButton.Select();
        }

        private void RigSearchResultsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( !(RigSearchResultsListView.SelectedItems.Count < 1 || RigSearchResultsListView.SelectedItems[0].Tag == null) )
            {
                Rig rig = (Rig)(RigSearchResultsListView.SelectedItems[0].Tag);
                ShowRigData(rig);
            }
            
        }

        private void BrowseTreeView_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            BrowseTreeCurrentNodeLabel.Text = e.Node.ToolTipText;
        }

        private void BrowseTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Level == 2)
            {
                ShowRigData((Rig)e.Node.Tag);
            } else
            {
                BrowseTreeCurrentNodeLabel.Text = (e.Node.Level == 0 ? "Setlist: " : "Song: ") + e.Node.Name;
                if (!e.Node.IsExpanded && !BrowseTreeViewCollapsing)
                {
                    e.Node.Expand();
                }
            }
            BrowseTreeViewCollapsing = false;
        }

        public void ShowRigData(Rig rig)
        {
            RigDataNameLabel2.Text = rig.name;

            if (rig.hasIR)
            {
                RigDataIRLabel2.Text = rig.IR;
            }
            else
            {
                RigDataIRLabel2.Text = "No IR";
            }
            RigDataListView.Items.Clear();

            foreach (Song song in rig.links.songs)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { song.song_name, song.setlist.name });
                RigDataListView.Items.Add(listViewItem);
            }
        }

        private bool BrowseTreeViewCollapsing = false;

        private void BrowseTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            BrowseTreeCurrentNodeLabel.Text = (e.Node.Level == 0 ? "Setlist: " : "Song: ") + e.Node.Name;
            BrowseTreeView.SelectedNode = e.Node;
        }

        private void BrowseTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            BrowseTreeCurrentNodeLabel.Text = (e.Node.Level == 0 ? "Setlist: " : "Song: ") + e.Node.Name;
            BrowseTreeViewCollapsing = true;
        }

        private void BrowseTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            BrowseTreeViewCollapsing = false;
        }

        private enum SearchTypeEnum
        {
            Rig,
            IR
        }

        private SearchTypeEnum searchType = SearchTypeEnum.Rig;

        private void SearchRadioRigButton_Click(object sender, EventArgs e)
        {
            RigSearchResultsListView.Items.Clear();
            RigSearchResultsListView.View = View.List;
            searchType = SearchTypeEnum.Rig;
            UpdateRigSearchResultsListView();
        }

        private void SearchRadioIRButton_Click(object sender, EventArgs e)
        {
            RigSearchResultsListView.Items.Clear();
            RigSearchResultsListView.View = View.Details;
            searchType = SearchTypeEnum.IR;
            UpdateRigSearchResultsListView();
        }

        private bool OnlyIRButtonState = false;

        private void OnlyIRButton_Click(object sender, EventArgs e)
        {
            OnlyIRButtonState = !OnlyIRButtonState;
            OnlyIRButton.Text = OnlyIRButton.Text == "No" ? "Yes" : "No";
            UpdateRigSearchResultsListView();
        }

        private bool OnlyRigsButtonState = false;

        private void OnlyRigsButton_Click(object sender, EventArgs e)
        {
            OnlyRigsButtonState = !OnlyRigsButtonState;
            OnlyRigsButton.Text = OnlyRigsButton.Text == "No" ? "Yes" : "No";
            UpdateRigSearchResultsListView();
        }
    }
}
