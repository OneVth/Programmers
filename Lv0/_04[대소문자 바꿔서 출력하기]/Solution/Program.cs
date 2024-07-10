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
            /*string changedString = "";

            foreach (char c in chars)
            {
                if (Char.IsUpper(c))
                {
                    char changedChar = Char.ToLower(c);
                    changedString += changedChar.ToString();
                }
                else
                {
                    char changedChar = Char.ToUpper(c);
                    changedString += changedChar.ToString();
                }
            }
            Console.WriteLine(changedString);*/

            foreach (char c in chars)
                Console.Write(Char.IsUpper(c) ? Char.ToLower(c) : Char.ToUpper(c));
        }
    }
}
