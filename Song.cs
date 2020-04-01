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

using System.Collections.Generic;

namespace HR_Backup_Manager
{
    public class Song
    {
        public string[] rig_names;
        public string[] rigs; // some sort of hexidecimal code
        public List<Rig> rigsList = new List<Rig>();
        public string song_id;
        private string _name;
        public string key;
#pragma warning disable IDE1006 // Naming Styles
        public string song_name
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
                key = value;
                _name = WF.UpperCammelCase.Convert(value);
            }
        }
        public Setlist setlist;

        public override string ToString()
        {
            return song_name;
        }
    }
}