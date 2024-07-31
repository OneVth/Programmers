using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr)
        {
            int[] answer = new int[] { };
            List<int> stk = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (stk.Count == 0) stk.Add(arr[i]);
                else
                {
                    if (stk[stk.Count - 1] == arr[i]) stk.RemoveAt(stk.Count - 1);
                    else stk.Add(arr[i]);
                }
            }
            return stk.Count == 0 ? new int[1] { -1 } : stk.ToArray();
        }

        public int[] solution2(int[] arr)
        {
            var answer = new Stack<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (answer.Count == 0)
                    answer.Push(arr[i]);
                else if (answer.Peek() == arr[i])
                    answer.Pop();
                else if (answer.Peek() != arr[i])
                    answer.Push(arr[i]);
            }
            if (answer.Count == 0) answer.Push(-1);
            int[] answerArr = new int[answer.Count];
            for (int i = answer.Count - 1; i >= 0; i--)
                answerArr[i] = answer.Pop();

            return answerArr;
        }
    }
}
