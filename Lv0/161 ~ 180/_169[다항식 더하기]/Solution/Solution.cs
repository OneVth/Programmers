using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string polynomial)
        {
            string answer = "";
            int constant = 0;
            int coefficient = 0;

            string[] array = polynomial.Split(" + ");

            foreach (string s in array)
            {
                if (s.Contains('x'))
                {
                    // Handle coefficient for terms with 'x'
                    if (s == "x")
                        coefficient++;
                    else
                        coefficient += int.Parse(s.Replace("x", ""));
                }
                else
                {
                    // Handle constant terms
                    constant += int.Parse(s);
                }
            }

            // Building the result string
            if (0 != coefficient)
            {
                answer = (coefficient == 1) ? "x" : coefficient + "x";
            }

            if (0 != constant)
            {
                if ("" != answer)
                {
                    answer += " + ";
                }
                answer += constant.ToString();
            }

            return answer;
        }
    }
}
