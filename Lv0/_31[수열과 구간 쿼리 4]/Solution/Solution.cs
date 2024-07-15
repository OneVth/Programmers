using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr)
        {
            int[] stk = new int[] { };
            int i = 0;
            List<int> temp = new List<int>();

            while (i < arr.Length)
            {
                if (temp.Count == 0)
                {
                    temp.Add(arr[i]);
                    i++;
                }
                else
                {
                    if (temp[temp.Count - 1] < arr[i])
                    {
                        temp.Add(arr[i]);
                        i++;
                    }
                    else
                    {
                        temp.RemoveAt(temp.Count - 1);
                    }
                }
            }

            stk = temp.ToArray();
            return stk;
        }
    }
}
