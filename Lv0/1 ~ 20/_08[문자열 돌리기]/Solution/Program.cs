using System;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();

            char[] chars = s.ToCharArray();

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
