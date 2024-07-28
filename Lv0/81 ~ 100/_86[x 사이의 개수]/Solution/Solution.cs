using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(string myString)
        {
            List<int> list = new List<int>();

            string[] temp = myString.Split("x");

            foreach (string s in temp)
            {
                list.Add(s.Length);
            }

            return list.ToArray();
        }
    }
}
