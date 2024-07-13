using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int a, int b, int c)
        {
            int answer = 0;

            if (a == b && b == c)
                answer = (a + b + c) * (a * a + b * b + c * c) * (a * a * a + b * b * b + c * c * c);
            else if ((a == b && b != c) || (a == c && a != b) || (b == c && c != a))
                answer = (a + b + c) * (a * a + b * b + c * c);
            else
                answer = a + b + c;

            return answer;
        }

        public int solution2(int a, int b, int c)
        {
            if(a == b && b == c)
            {
                int temp_a = a + b + c;
                int temp_b = a * a + b * b + c * c;
                int temp_c = a * a * a + b * b * b + c * c * c;

                return temp_a * temp_b * temp_c;
            }
            else if(a != b && b != c && c != a)
            {
                return a + b + c;
            }

            return (a + b + c) * (a * a + b * b + c * c);
        }

        public int solution3(int a, int b, int c)
        {
            int answer = 1;

            for (int i = ((a == b || a == c) ? 1 : 0) + ((b == c) ? 1 : 0) + 1; i != 0; i--)
                answer *= (int)(Math.Pow(a, i) + Math.Pow(b, i) + Math.Pow(c, i));

            return answer;
        }
    }
}
