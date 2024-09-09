using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string X, string Y)
        {
            int[] freqX = new int[10];
            int[] freqY = new int[10];

            foreach (char c in X)
            {
                freqX[c - '0']++;
            }

            foreach (char c in Y)
            {
                freqY[c - '0']++;
            }

            StringBuilder result = new StringBuilder();
            for (int digit = 9; digit >= 0; digit--)
            {
                int commonCount = Math.Min(freqX[digit], freqY[digit]);

                for (int i = 0; i < commonCount; i++)
                {
                    result.Append(digit);
                }
            }

            if (result.Length == 0)
                return "-1";
            if (result.ToString()[0] == '0')
                return "0";

            return result.ToString();
        }
    }
}
