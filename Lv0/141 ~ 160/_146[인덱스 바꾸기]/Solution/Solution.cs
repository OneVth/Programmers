using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int num1, int num2)
        {
            char[] cArray = my_string.ToCharArray();

            char tmp = cArray[num1];
            cArray[num1] = cArray[num2];
            cArray[num2] = tmp;

            return new string(cArray);
        }
    }
}
