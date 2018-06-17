using System;

namespace FindstringLength
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the string:");
            string s = Console.ReadLine();
            int i = 0;
            if (s != null)
                foreach (var c in s)
                {
                    i++;
                }

            Console.WriteLine("the length of the string is "+i);
            
            // can also use try catch block
//            try
//            {
//                while (true)
//                {
//                    if (s != null)
//                    {
//                        char c = s[i];
//                    }
//
//                    i++;    
//                }
//                
//            }
//            catch (IndexOutOfRangeException e)
//            {
//                Console.WriteLine("The length of the string is " + i);
//            }
        }
    }
}