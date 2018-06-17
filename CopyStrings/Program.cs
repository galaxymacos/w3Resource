using System;
using System.Data.SqlTypes;

namespace CopyStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string[] str2 = new string[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                str2[i] = str1[i].ToString();
            }

            string result = string.Join("", str2);
            Console.WriteLine(result);
        }
    }
}