using System;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);

            Console.WriteLine((a % 2 == 0) ? $"{a} is even" : $"{a} is odd");
        }
    }
}
