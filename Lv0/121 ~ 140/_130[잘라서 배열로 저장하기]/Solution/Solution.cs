using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string my_str, int n)
        {
            string[] answer = new string[] { };
            List<string> list = new List<string>();

            int iterateNum = (my_str.Length + (n - 1)) / n;
            for (int i = 0; i < iterateNum; i++)
            {
                list.Add(new string(my_str.Skip(i * n).Take(n).ToArray()));
            }

            return list.ToArray();
        }
    }
}
