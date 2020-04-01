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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HR_Backup_Manager
{
    class JSON
    {
        static public T Read<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str); ;
        }

        static public string Write(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        static public JObject ReadLinq(string str)
        {
            return JObject.Parse(str);
        }
    }
}
