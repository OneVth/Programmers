using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string rsp)
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
    }
}
