using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StringMethods
    {
        /// <summary>
        /// Encodes the string so plain text isn't traveling across the network
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Encode(string plainText)
        {
            if (plainText == null)
                return null;

            // Yes, this is very easy to decode for anyone monitoring network traffic... 
            // but we'll change it up when the code isn't public :P 
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Reverse operation of our encoder
        /// </summary>
        /// <param name="encoded"></param>
        /// <returns></returns>
        public static string Decode(string encoded)
        {
            if (encoded == null)
                return null;

            var base64EncodedBytes = Convert.FromBase64String(encoded);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
