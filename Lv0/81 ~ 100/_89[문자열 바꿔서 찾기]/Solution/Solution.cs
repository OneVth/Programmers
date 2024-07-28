using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string myString, string pat)
        {
            return new string(myString.Select(w => w == 'A' ? 'B' : 'A').ToArray()).Contains(pat) ? 1 : 0;
        }

        public int solution2(string myString, string pat)
        {
            myString = myString.Replace("A", "b")
                .Replace("B", "a");

            return myString.Contains(pat.ToLower()) ? 1 : 0;
        }
        public int solution3(string myString, string pat)
        {
            List<char> list = new List<char>();

            foreach (char c in myString)
            {
                if (c == 'A') list.Add('B');
                else list.Add('A');
            }


            string temp = new string(list.ToArray());
            return temp.Contains(pat) ? 1 : 0;
        }
    }
}
