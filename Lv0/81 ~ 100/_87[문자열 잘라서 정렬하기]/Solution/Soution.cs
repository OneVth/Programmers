using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Soution
    {
        public string[] solution(string myString)
        {
            string[] answer = myString.Split("x");
            answer = answer.Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
            Array.Sort(answer);
            return answer;
        }
    }
}
