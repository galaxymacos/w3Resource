using System;
using System.Collections.Generic;

namespace MaximumOccuringCharacterInString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            int maximumNumber = 0;
            char maximumChar = ' ';
            foreach (char c in s)
            {
                if (!dictionary.ContainsKey(c))
                {
                    dictionary.Add(c,1);
                }
                else
                {
                    dictionary[c]++;
                }

                if (dictionary[c] <= maximumNumber) continue;
                maximumNumber = dictionary[c];
                maximumChar = c;
            }

            Console.WriteLine($"{maximumChar} occurs {dictionary[maximumChar]} times");
        }
    }
}