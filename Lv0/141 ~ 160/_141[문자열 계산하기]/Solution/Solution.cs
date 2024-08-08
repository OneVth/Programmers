using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string my_string)
        {
            string[] array = my_string.Split(" ");
            int answer = int.Parse(array[0]);

            // 연산자는 i가 홀수일때마다 반복
            for (int i = 1; i < array.Length; i += 2)
            {
                string op = array[i];
                switch (op)
                {
                    case "+":
                        answer += int.Parse(array[i + 1]);
                        break;
                    case "-":
                        answer -= int.Parse(array[i + 1]);
                        break;
                }
            }

            return answer;
        }
    }
}
