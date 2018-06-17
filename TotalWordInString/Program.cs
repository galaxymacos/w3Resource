using System;

namespace TotalWordInString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] words = s.Split(new char[]{' ','\n', '\t'},StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("the number of words is "+words.Length);
        }
    }
}