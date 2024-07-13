using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string code)
        {
            string ret = "";
            int mode = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < code.Length; i++)
            {
                switch (mode)
                {
                    case 0:
                        if (code[i] == '1') mode = 1;
                        else
                            if (i % 2 == 0) sb.Append(code[i]);
                        break;
                    case 1:
                        if (code[i] == '1') mode = 0;
                        else
                            if (i % 2 == 1) sb.Append(code[i]);
                        break;
                }
            }

            ret = sb.ToString();

            return string.IsNullOrEmpty(ret) ? "EMPTY" : ret;
        }
    }
}
