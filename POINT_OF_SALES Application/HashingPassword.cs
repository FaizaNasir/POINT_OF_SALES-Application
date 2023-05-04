using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALES_Application
{
    class HashingPassword
    {
        public string Encryption(string password)
        {
            Byte[] bytes = System.Text.Encoding.Unicode.GetBytes(password);
            string Encryptd_Pass = Convert.ToBase64String(bytes);
            return Encryptd_Pass;
        }

        public string Decryption(string Encrypted_Password )
        {
            Byte[] bytes = Convert.FromBase64String(Encrypted_Password);
            string Decryption = System.Text.Encoding.Unicode.GetString(bytes);
            return Decryption;

        }
    }
}
