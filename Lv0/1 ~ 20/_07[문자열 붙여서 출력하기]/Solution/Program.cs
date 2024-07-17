using System;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            String s2 = input[1];

            Console.WriteLine(s1 + s2);
        }
    }
}
