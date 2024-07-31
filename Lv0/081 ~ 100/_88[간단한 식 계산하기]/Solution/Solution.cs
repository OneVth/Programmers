using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string binomial)
        {
            int answer = 0;
            string[] splited = binomial.Split(" ");
            char[] op = splited[1].ToCharArray();
            switch ((int)op[0]) // check op
            {
                case 42: // op is "*"
                    answer = int.Parse(splited[0]) * int.Parse(splited[2]);
                    break;
                case 43: // op is "+"
                    answer = int.Parse(splited[0]) + int.Parse(splited[2]);
                    break;
                case 45: // op is "-"
                    answer = int.Parse(splited[0]) - int.Parse(splited[2]);
                    break;
            }
            return answer;
        }

        public int solution2(string binomial)
        {
            string[] splited = binomial.Split();

            int a = int.Parse(splited[0]);
            string op = splited[1];
            int b = int.Parse(splited[2]);

            if (op == "+") return a + b;
            if (op == "-") return a - b;
            if (op == "*") return a * b;

            return 0;
        }
    }
}
