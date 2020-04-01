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
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Backup_Manager
{
    public partial class WF
    {

        public Logs logs;


        private WF() {
            logs = new Logs();
        }

        private static WF instance;

        public static WF Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WF();
                }
                return instance;
            }
        }

        
        public class Logs
        {
            private readonly List<string> logs;

            public Logs()
            {
                logs = new List<string>();
            }

            public void Add(string str)
            {
                logs.Add(str);
            }

            public string GetAll()
            {
                string result = "";
                foreach (string str in logs)
                {
                    result += str + "\r\n";
                }
                if (result.Length > 2)
                {
                    result = result.Substring(0, result.Length - 2);
                }
                return result;
            }
        }


        public String Implode(String glue, String[] array)
        {
            String str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + glue;
            }
            return str.Remove(str.Length - glue.Length);
        }


        public class UpperCammelCase
        {
            private static UpperCammelCase instance;

            private readonly TextInfo textInfo;

            private UpperCammelCase()
            {
                textInfo = new CultureInfo("en-US", false).TextInfo;
            }

            public static string Convert(string str)
            {
                if (instance == null)
                {
                    instance = new UpperCammelCase();
                }
                return instance.convert(str);
            }

#pragma warning disable IDE1006 // Naming Styles
            public string convert(string str)
#pragma warning restore IDE1006 // Naming Styles
            {
                return textInfo.ToTitleCase(textInfo.ToLower(str));
            }
        }

        public  bool IsFontInstalled(string fontName)
        {
            bool installed = IsFontInstalled(fontName, FontStyle.Regular);
            if (!installed) { installed = IsFontInstalled(fontName, FontStyle.Bold); }
            if (!installed) { installed = IsFontInstalled(fontName, FontStyle.Italic); }

            return installed;
        }

        public  bool IsFontInstalled(string fontName, FontStyle style)
        {
            bool installed = false;
            const float emSize = 8.0f;

            try
            {
                using (var testFont = new Font(fontName, emSize, style))
                {
                    installed = (0 == string.Compare(fontName, testFont.Name, StringComparison.InvariantCultureIgnoreCase));
                }
            }
            catch
            {
            }

            return installed;
        }

    }

    public static class TreeViewExtensionMethods
    {

        public static List<TreeNode> GetAllNodes(this TreeView _self)
        {
            List<TreeNode> result = new List<TreeNode>();
            foreach (TreeNode child in _self.Nodes)
            {
                result.AddRange(child.GetAllNodes());
            }
            return result;
        }

        public static List<TreeNode> GetAllNodes(this TreeNode _self)
        {
            List<TreeNode> result = new List<TreeNode>();
            result.Add(_self);
            foreach (TreeNode child in _self.Nodes)
            {
                result.AddRange(child.GetAllNodes());
            }
            return result;
        }
    }

}
