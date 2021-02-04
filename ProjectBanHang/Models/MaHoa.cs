using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;


namespace ProjectBanHang.Models
{
    public class MaHoa
    {
        static public string GetMd5Hash( string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (MD5 md5Hash = MD5.Create())
            {
                //string hash = GetMd5Hash(md5Hash, source);

                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                //Console.WriteLine("The MD5 hash of " + source + " is: " + hash + ".");

                //Console.WriteLine("Verifying the hash...");

                //if (VerifyMd5Hash(md5Hash, source, hash))
                //{
                //    Console.WriteLine("The hashes are the same.");
                //}
                //else
                //{
                //    Console.WriteLine("The hashes are not same.");
                //}
            }
            // Convert the input string to a byte array and compute the hash.
            

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}