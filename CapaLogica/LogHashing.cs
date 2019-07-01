using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogHashing
    {
        #region Singleton

        static LogHashing()
        {

        }

        private LogHashing()
        {

        }

        public static LogHashing Instance { get; } = new LogHashing();

        #endregion Singleton

        public string Encrypt(List<string> hash)
        {
            return String.Join("",hash.ToArray());
        }

        public string Decrypt(List<string> hash)
        {
            
            Array newHash = hash.ToArray();
            Array.Reverse(newHash);
            List<string> pass = new List<string>();
            foreach(var i in newHash)
            {
                int code = Convert.ToInt32(i);
                char character = (char)code;
                pass.Add(character.ToString());
            }
            return String.Join("",pass.ToArray());
        }

    }
}
