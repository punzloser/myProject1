using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem
{
    class HashPass
    {
        public String Hash(String data)
        {
            SHA1 sha = SHA1.Create();
            byte[] hash = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                returnValue.Append(hash[i].ToString());
            }

            return returnValue.ToString();
        }
    }
}
