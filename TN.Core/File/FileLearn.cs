using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TN.Core.Control;
using TN.Core.Model;
using TN.Core.Security;

namespace TN.Core.File
{
    public class FileLearn
    {
        public static bool SaveProcess(IList<Learn> learns,string username, string password)
        {
            String text = JsonConvert.SerializeObject(learns);
            LearnDay learnDay = new LearnDay();
            learnDay.DateTime = DateTime.Now;
            learnDay.Username = username;
          
            learnDay.LearnText = text;

            String textEncode = AESEncode.EncryptStringAES(JsonConvert.SerializeObject(learnDay), username + "9Ud" + password + "Ksm");
            return FileManager.WriteFile(textEncode,username+"Learn");
        }

        public static IList<Learn> ReadProcess(string username, string password)
        {
            var textEncode = FileManager.ReadFile(username + "Learn");
            if (textEncode == null) return null;
            var textDecode = AESEncode.DecryptStringAES(textEncode, username + "9Ud" + password + "Ksm");
            var learnDay = JsonConvert.DeserializeObject<LearnDay>(textDecode);
            if (learnDay.DateTime.Date == DateTime.Now.Date)
            {
                return JsonConvert.DeserializeObject<IList<Learn>>(learnDay.LearnText);
            }
            if (learnDay.DateTime.AddDays(1) < DateTime.Now.Date)
            {
                return null;
            }
            if (learnDay.DateTime.Date.AddDays(1) == DateTime.Now.Date)
            {
                LearnControl.SaveLearn(JsonConvert.DeserializeObject<IList<Learn>>(learnDay.LearnText));
            }

            return null;

        } 
    }

    class LearnDay
    {

        public string Username { get; set; }
        
        public DateTime DateTime { get; set; }
        public string LearnText { get; set; }

        
        
    }
}
