using System;
using System.Linq;

namespace CompareTwoStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("The first string: ");
            string firstStr = Console.ReadLine();
            Console.WriteLine("The second string: ");
            string secondStr = Console.ReadLine();
            if (firstStr.Length != secondStr.Length)
            {
                Console.WriteLine("not equal");
                return;
            }

            if (firstStr.Where((t, i) => t != secondStr[i]).Any())
            {
                Console.WriteLine("not equal");
                return;
            }

            Console.WriteLine("equal");
    }
}
        }