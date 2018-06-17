using System;
using System.Collections.Generic;

namespace FindAlphabetsDigitsAndSpecialCharacters
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countAlphabet = 0;
            int countNumber = 0;
            int countSpecial = 0;
            foreach (var character in s)
            {
                if (character <= '9' && character >= '0')
                {
                    countNumber++;
                }

                else if (character <= 'z' && character >= 'a' || character <= 'Z' && character >= 'A')
                {
                    countAlphabet++;
                }

                else
                {
                    countSpecial++;
                }
            }

            Console.WriteLine("total of alphabets in the string is " + countAlphabet);
            Console.WriteLine("total of digits in the string is " + countNumber);
            Console.WriteLine("total of special number in the string is " + countSpecial);
        }
    }
}