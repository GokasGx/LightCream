using System;
using System.IO;

namespace LightCream
{
    public class Tools
    {
        public static string EncryptCesar(string txt, bool crypt, int key)
        {
            string output = string.Empty;
            foreach (char c in txt)
            output += (char)( (int)(c) + ( crypt ? key:-key ));
            return output;
        }
    }
}