using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] quiz)
        {
            List<string> list = new List<string>();
            int length = quiz.GetLength(0);
            string[] temp = new string[5];
            int a = 0, b = 0, rlt = 0;
            string op, result;

            for (int i = 0; i < length; i++)
            {
                temp = quiz[i].Split(" ");

                a = int.Parse(temp[0]);
                op = temp[1];
                b = int.Parse(temp[2]);
                rlt = int.Parse(temp[4]);

                switch (op)
                {
                    case "+":
                        result = a + b == rlt ? "O" : "X";
                        list.Add(result);
                        break;
                    case "-":
                        result = a - b == rlt ? "O" : "X";
                        list.Add(result);
                        break;
                }
            }

            return list.ToArray();
        }
    }
}
