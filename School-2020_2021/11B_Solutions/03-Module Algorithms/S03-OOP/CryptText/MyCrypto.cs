using System;
using System.Collections.Generic;
using System.Text;

namespace CryptText
{
    public class MyCrypto
    {
        public static string EncryptString(string plainText)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < plainText.Length; i++)
            {
                builder.Append((char)(plainText[i] + 3));
            }
            return builder.ToString();
        }

        public static string DecryptString(string cipherText)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < cipherText.Length; i++)
            {
                builder.Append((char)(cipherText[i] - 3));
            }
            return builder.ToString();
        }
    }
}
