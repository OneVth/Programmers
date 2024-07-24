using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] arr)
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

        public int solution2(int[] arr)
        {
            int answer = 0;
            int num = 0;

            while (true)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50 && arr[i] % 2 == 0) arr[i] /= 2;
                    else if (arr[i] < 50 && arr[i] % 2 != 0) arr[i] = 2 * arr[i] + 1;
                    else num++;
                }
                if (num == arr.Length) break;
                else
                {
                    num = 0;
                    answer++;
                }
            }
            return answer;
        }

        public int solution3(int[] arr)
        {
            int x = 0;

            while (true)
            {
                int[] other = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    int n = arr[i];
                    if (n >= 50 && n % 2 == 0) n = n / 2;
                    else if (n < 50 && n % 2 == 1) n = n * 2 + 1;

                    other[i] = n;
                }

                if (Enumerable.SequenceEqual(arr, other)) break;

                var temp = other;
                other = arr;
                arr = other;
                x++;
            }
            return x;
        }
    }
}
