﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    answer += i;
            }

            return answer;
        }

        public int solution2(int n)
        {
            int sum = 0;

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i)
                        sum += n / i;
                }
            }

            return sum;
        }
    }
}
