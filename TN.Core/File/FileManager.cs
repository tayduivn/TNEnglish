using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN.Core.Security;

namespace TN.Core.File
{
    public class FileManager
    {
        public static bool WriteFile(string str,string name)
        {
            try
            {
                string text = AESEncode.EncryptStringAES(str, "kIenlhilnO98e");
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("Appdata/Temp/" + name + ".txt", false))
                {
                    file.WriteLine(text);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public static string ReadFile(string name)
        {
            try
            {
                var text = System.IO.File.ReadAllText("Appdata/Temp/" + name + ".txt");
                return AESEncode.DecryptStringAES(text, "kIenlhilnO98e");
             
            }
            catch (Exception)
            {
                return null;
            }
          
        }
    }
}
