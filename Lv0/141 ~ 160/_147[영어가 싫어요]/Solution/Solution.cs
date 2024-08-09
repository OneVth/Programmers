using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public long solution(string numbers)
        {
            string[] szArray = new string[10] 
            { 
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" 
            };

            for (int i = 0; i < szArray.Length; i++)
            {
                numbers = numbers.Replace(szArray[i], i.ToString());
            }

            return long.Parse(numbers);
        }
    }
}
