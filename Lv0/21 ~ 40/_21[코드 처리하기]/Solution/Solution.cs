using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string code)
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

        public string solution2(string code)
        {
            var sb = new StringBuilder();
            bool mode = false; // false == 0

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '1')
                    mode = !mode;
                else if ((mode && i % 2 == 1) || (!mode && i % 2 == 0))
                    sb.Append(code[i]);
            }

            return sb.ToString() == string.Empty ? "EMPTY" : sb.ToString();
        }
    }
}
