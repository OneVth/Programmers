using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string a, string b)
        {
            int s = 0;
            int c = 0;
            List<int> list = new List<int>();
            StringBuilder sb = new StringBuilder();

            // 문자열 길이 맞추기
            a = (a.Length > b.Length) ? a : a.PadLeft(b.Length, '0');
            b = (a.Length > b.Length) ? b.PadLeft(a.Length, '0') : b;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                // s: carry + 두 인수, c: carry
                s = ((a[i] - '0') + (b[i] - '0')) % 10 + c;
                c = ((a[i] - '0') + (b[i] - '0')) / 10;

                if (s == 10)
                {
                    s = 0;
                    c = 1;
                }

                list.Add(s);
            }

            // 마지막 계산 carry 있으면 add 1
            if (c == 1) list.Add(c);
            list.Reverse();

            foreach (int i in list)
            {
                sb.Append(i);
            }
            return sb.ToString();
        }
    }
}
