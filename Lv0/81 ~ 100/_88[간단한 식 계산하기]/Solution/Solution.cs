using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string binomial)
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
    }
}
