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
    public class Setlist
    {
        // JSON properties
        public string author;
        public int created_at;
        public string id;
        public bool @readonly;
        public Song[] songs;
        public string version;

        // Derived properties
#pragma warning disable IDE1006 // Naming Styles
        public string name {
#pragma warning restore IDE1006 // Naming Styles
            get
            {
                if(Properties.Settings.Default.AllCaps == "No")
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

        public override string ToString()
        {
            return name;
        }
    }
}


/* 
 *
 * {
   "author":"UserName",
   "created_at":1558906088,
   "id":"f9cbdc51-606f-46ad-aa9e-7da7bc6cd101",
   "readonly":false,
   "songs":[
      {
         "rig_names":[
            "-CLEAN ANOTHER BRICK",
            "+SOLO ANOTHER BRICK",
            "+SOLO2 ANOTHER BRICK",
            "+DRIVE ANOTHER BRICK",
            "BLUEBASS STANDARD"
         ],
         "rigs":[
            "2b7310a4-4d2f-47a6-89e8-57e6278a488c",
            "ce64354b-951b-4737-9f1c-6d1771ccfd94",
            "a43d18de-4a8c-4a2e-8620-4025e7874380",
            "18d30d72-f9fe-441e-a5d8-cabd22ad53ad",
            "7ffe51d0-5218-4fd7-ad14-6d941fde9a45"
         ],
         "song_id":"6e8e2c21-d2c9-44f0-a1d0-8b0d5c986e98",
         "song_name":"ANOTHER BRICK"
      },
      {
         "rig_names":[
            "-RHYTHM TIME",
            "-LUSH TIME",
            "-LEAD3 TIME",
            "-LEAD2 TIME",
            "-LEAD TIME"
         ],
         "rigs":[
            "c7e1339b-17e7-4262-b6e2-aa45cd423992",
            "3debb96f-30e6-4cd2-b729-b1aaf411eb85",
            "e55d27a2-6f54-44e0-a5c4-ae798183343b",
            "b4a69675-5bfe-4345-bdac-3a51871acbdb",
            "7be3d882-88e2-4c04-bbf6-4f26eec45ea9"
         ],
         "song_id":"a34e16ea-e99c-44c9-a367-0c03e952cebd",
         "song_name":"TIME"
      },
      {
         "rig_names":[
            "+J45 OD WAH",
            "+MARIO",
            "+DUO LEAD"
         ],
         "rigs":[
            "afad53f6-f9b9-4451-a89b-e96db16b71b2",
            "bf1f4b3f-2a67-42fc-831c-713b1ac0f58b",
            "959b9c42-afd1-4c6d-bf43-9ada9e8b3050"
         ],
         "song_id":"0c7ccb86-ddbd-4d33-840a-fb59d12f4a0f",
         "song_name":"SUPER MARIO"
      },
      {
         "rig_names":[
            "+PLUSH"
         ],
         "rigs":[
            "14075668-2222-492f-b563-5b205afc0c53"
         ],
         "song_id":"126c14ec-dbc5-466b-958a-4faad36eb531",
         "song_name":"PLUSH"
      },
      {
         "rig_names":[
            "+STP ILS"
         ],
         "rigs":[
            "11f8f20f-f5e2-4fcf-9878-da74f94d3afc"
         ],
         "song_id":"67037944-d4c1-48a0-8f82-b01437f2091c",
         "song_name":"INTERSTATE LOVE SONG"
      },
      {
         "rig_names":[
            "+RHY IMMIGRANT"
         ],
         "rigs":[
            "e7497d90-826a-4a28-9109-73bfc3750a5c"
         ],
         "song_id":"1161db5a-26e9-4523-bef3-8906a1afe43b",
         "song_name":"IMMIGRANT SONG"
      },
      {
         "rig_names":[
            "+65SR JERRY"
         ],
         "rigs":[
            "6254a103-2d9d-4b74-a713-b5cc39b8c769"
         ],
         "song_id":"89511f8f-0564-4fb8-b87f-e88288614de5",
         "song_name":"FRIEND OF THE DEVIL"
      },
      {
         "rig_names":[
            "+TWO RIVERS 1",
            "+TWO RIVERS 2",
            "+TWO RIVERS 3",
            "+TWO RIVERS 4"
         ],
         "rigs":[
            "7006e238-a578-4d4c-9125-6dc4c5c134ab",
            "2b013c17-5eef-4499-bd31-130e2765b5af",
            "eb4335fb-1d34-4ae1-b3c0-bc4db5f06129",
            "74efdc33-0725-4114-aa5e-139c4526d823"
         ],
         "song_id":"8d1cde25-caa5-4d80-9df0-7b5bd2fe8157",
         "song_name":"TWO RIVERS"
      },
      {
         "rig_names":[
            "+VOXMOD PHASER",
            "+J45 OD WAH",
            "+800BASS",
            "+PLEX-SOLDANO MUFF",
            "+SLO2"
         ],
         "rigs":[
            "2b17beba-942a-4532-b7c0-fa66263bc1e0",
            "afad53f6-f9b9-4451-a89b-e96db16b71b2",
            "9eb9e0fe-8c59-4811-9f4e-d15f17094e63",
            "357f4e5e-ac92-4cf8-a7bf-136df725b8fd",
            "8b283928-46c8-46c9-9117-e2695fb15ea1"
         ],
         "song_id":"a9ec8978-29a2-4478-917f-fb5fae5b085e",
         "song_name":"SLOWLY CHILLIN"
      },
      {
         "rig_names":[
            "+PV TEEN SPIRIT"
         ],
         "rigs":[
            "12011d0c-cfd4-4ea1-a05d-8ecbd6274362"
         ],
         "song_id":"c61fdb08-abc4-4afa-890d-5a1a267c44d7",
         "song_name":"TEEN SPIRIT"
      },
      {
         "rig_names":[
            "+STP DRIVE"
         ],
         "rigs":[
            "691ce3c5-94f2-4587-b21a-e5cb8eb2008e"
         ],
         "song_id":"ae793004-3b10-4478-91bd-755a4253f5a7",
         "song_name":"VASOLINE"
      },
      {
         "rig_names":[
            "+RUNAWAY TRAIN"
         ],
         "rigs":[
            "b77ed126-8204-4bb8-a4e7-c992e689919b"
         ],
         "song_id":"742be200-3a66-4db2-9c5f-ac7a33eeeb57",
         "song_name":"RUNAWAY TRAIN"
      },
      {
         "rig_names":[
            "+GIVEN TO FLY",
            "+FOOFIGHTER DRIVE"
         ],
         "rigs":[
            "387b93c6-adbe-4771-9079-cc1ed2701802",
            "0a3de2fb-e03f-415f-85c5-c21045716dd9"
         ],
         "song_id":"6cad6252-6477-4c29-846e-ece3aa5d7ae5",
         "song_name":"GIVEN TO FLY"
      },
      {
         "rig_names":[
            "-INUTERO RHYTHM",
            "-INUTERO DRIVE",
            "-INUTERO LEAD",
            "-EVERLONG",
            "+PV SINGIN",
            "BLUEBASS STANDARD",
            "+ILS SLIDE",
            "+DRIVE PHAIRY",
            "+CLEAN PHAIRY",
            "+THICK PHAIRY",
            "BLUEBASE STANDARD 2",
            "-SUGAR MAGNOLIA",
            "-LEAD SUGAR MAGNOLIA",
            "+LEAD SUGAR MAGNOLIA",
            "+LEAD SUGAR MAG",
            "-DG LEAD",
            "+REVERSE DELAY",
            "+OLD WINE",
            "+59BASS OD BLISS"
         ],
         "rigs":[
            "bf6fa5e6-582c-44e8-9102-5257caa65da3",
            "5d657e79-cef0-4c00-878a-9e002774be90",
            "c6e80644-3cab-4c0d-b649-17d1dfd8123c",
            "bde8d54b-a589-4b0d-9bc3-51c7a2856073",
            "8fc03091-9824-4587-853f-b557ce5186c6",
            "7ffe51d0-5218-4fd7-ad14-6d941fde9a45",
            "6b14d50c-1d92-43ce-9149-49f6450954f8",
            "3ec032e4-70cc-4240-a25b-fa79d68cdd06",
            "173d68af-a15c-4bd1-ad84-e0b37991d1ad",
            "18e2d8ef-38b0-4d96-b358-7509ab220933",
            "51200940-fbe3-470c-b7cc-2f2c6ff0282d",
            "895328f5-de10-4301-80b3-d61bc7888f49",
            "6add0c21-7c2a-4c35-954d-1299e1eeb721",
            "0b493302-2ae2-4f85-9cc4-c28394eaeca9",
            "c90ed2f7-6d82-4a8b-b351-30a09431e604",
            "fe369b22-2caa-4f70-a8d2-18b64aa0ed2b",
            "f18c93e7-c439-45b3-b20f-b1a9d21606d9",
            "72751b54-804f-49a5-b052-2b05cc919d9e",
            "6b7e1dcd-d956-4db3-8e6e-7f1453ca0da5"
         ],
         "song_id":"a11e2429-e068-4631-9cce-ae24ab9dad5d",
         "song_name":"HEART SHAPED BOX"
      },
      {
         "rig_names":[
            "+800BASS AMBIENT LD",
            "+PVLD MUFF",
            "_BLBASS STANDARD"
         ],
         "rigs":[
            "583f7753-44cc-47b7-a728-3ac3f642533a",
            "168c32cf-e3a3-4ddb-ade1-b2967c5b775c",
            "8d058232-0e95-46ed-8340-847b70846ede"
         ],
         "song_id":"1466e5fd-2351-4fe4-b9ae-2830dcafa831",
         "song_name":"DARK MATTER"
      }
   ],
   "version":"2.0.0"
}
*/
