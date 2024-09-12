﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(int[] food)
        {
            string[] chunk = new string[2];
            StringBuilder temp = new StringBuilder();

            for (int i = 1; i < food.Length; i++)
            {
                for (int j = 0; j < food[i] / 2; j++)
                {
                    temp.Append(i);
                }
            }

            chunk[0] = temp.ToString();
            char[] cArray = chunk[0].ToCharArray();
            Array.Reverse(cArray);
            chunk[1] = new string(cArray);

            return string.Join("0", chunk);
        }
    }
}
