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
            int b = Int32.Parse(s[1]);

            Console.Write(a + " + " + b + " = ");
            Console.WriteLine("{0}", a + b);
        }
    }
}
