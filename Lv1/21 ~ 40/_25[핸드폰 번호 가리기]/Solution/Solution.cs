using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string phone_number)
        {
            string temp = new String('*', phone_number.Length - 4);
            string lastNumber = phone_number.Substring(phone_number.Length - 4);
            return String.Concat(temp, lastNumber);
        }

        public string solution2(string phone_number)
        {
            return phone_number.Substring(phone_number.Length - 4).PadLeft(phone_number.Length, '*');
        }
    }
}
