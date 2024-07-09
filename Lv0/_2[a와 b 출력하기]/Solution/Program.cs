using System;
using System.Linq;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            /*s = Console.ReadLine().Split(' ');

            if (int.TryParse(s[0], out int a))
                Console.WriteLine("a = {0}", a);

            if (int.TryParse(s[1], out int b))
                Console.WriteLine("b = {0}", b);*/

            int[] i = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("a = {0}", i[0]);
            Console.WriteLine("b = {0}", i[1]);
        }
    }
}
