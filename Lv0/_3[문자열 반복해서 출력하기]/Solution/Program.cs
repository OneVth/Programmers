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
            int a = Int32.Parse(input[1]);

            for (int i = 0; i < a; i++)
            {
                Console.Write(s1);
            }
        }
    }
}
