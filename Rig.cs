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
using System.Text;
using System.Threading.Tasks;

namespace HR_Backup_Manager
{
    public class Rig
    {
        public string author;
        public int color;
        public string content;
        public Newtonsoft.Json.Linq.JObject contentData;
        public int created_at;
        public string id;
        public int order;
        public int prog_num;
        public bool @readonly;
        public bool inSetlist = false;


#pragma warning disable IDE1006 // Naming Styles
        public string name
#pragma warning restore IDE1006 // Naming Styles
        {
            get
            {
                if (Properties.Settings.Default.AllCaps == "No")
                {
                    return _name;
                }
                else
                {
                    return key;
                }
            }
            set
            {
                _name = WF.UpperCammelCase.Convert(value);
            }
        }
        private string _name;

        public string key;
        public string IR;
        public bool hasIR;
        public RigLinks links = new RigLinks();

        public override string ToString()
        {
            return name;
        }
    }

    public class RigLinks
    {
        public List<Song> songs = new List<Song>();
        public List<Setlist> setlists = new List<Setlist>();
    }
}
