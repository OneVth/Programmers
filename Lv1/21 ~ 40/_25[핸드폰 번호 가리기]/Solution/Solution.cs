using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string phone_number)
        {
            string temp = new String('*', phone_number.Length - 4);
            string lastNumber = phone_number.Substring(phone_number.Length - 4);
            return String.Concat(temp, lastNumber);
        }
    }
}
