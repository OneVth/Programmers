using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] arr)
        {
            int answer = 0;
            bool isEqual = false;

            int[] curArray = new int[arr.Length];
            int[] temp = (int[])arr.Clone();

            while (!isEqual)
            {
                List<int> list = new List<int>();

                foreach (int i in temp)
                {
                    if (i >= 50 && i % 2 == 0) list.Add(i / 2);
                    else if (i < 50 && i % 2 == 1) list.Add(i * 2 + 1);
                    else list.Add(i);
                }

                curArray = list.ToArray();

                isEqual = true; // Assume arrays are equal initially
                for (int i = 0; i < arr.Length; i++)
                {
                    if (curArray[i] != temp[i])
                    {
                        isEqual = false;
                        break;
                    }
                }

                if (!isEqual)
                {
                    temp = (int[])curArray.Clone();
                    answer++;
                }
            }

            return answer;
        }
    }
}
