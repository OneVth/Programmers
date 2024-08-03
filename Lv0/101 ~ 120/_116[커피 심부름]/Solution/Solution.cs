using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string[] order)
        {
            int answer = 0;

            foreach (string s in order)
            {
                if (s == "iceamericano" || s == "americanoice" || s == "hotamericano" || s == "americanohot" || s == "americano" || s == "anything")
                    answer += 4500;
                else
                    answer += 5000;
            }

            return answer;
        }

        public int solution2(string[] order)
        {
            return Enumerable.Range(0, order.Length)
                .Select(s => order[s].Contains("cafelatte") ? 5000 : 4500)
                .Sum();
        }

        public int solution3(string[] order)
        {
            int cafelatte = order.Count(c => c.Contains("cafelatte"));
            int americano = order.Length - cafelatte;

            return cafelatte * 5000 + americano * 4500;
        }
    }
}
