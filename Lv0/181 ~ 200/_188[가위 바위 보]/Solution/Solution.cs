using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string rsp)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in rsp)
            {
                switch (c)
                {
                    case '0':
                        sb.Append('5');
                        break;
                    case '2':
                        sb.Append('0');
                        break;
                    case '5':
                        sb.Append('2');
                        break;
                }
            }

            return sb.ToString();
        }
        public string solution2(string rsp)
        {
            StringBuilder sb = new StringBuilder();
            char[] toWin = {
            '5', '-', '0', '-', '-', '2'
        };

            int[] temp = rsp.Select(s => s - '0').ToArray();
            for (int i = 0; i < rsp.Length; i++)
            {
                sb.Append(toWin[temp[i]]);
            }
            return sb.ToString();
        }
    }
}
