using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int k)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Count == k) return list.ToArray();

                if (list.Count == 0)
                    list.Add(arr[i]);
                else
                {
                    if (!list.Contains(arr[i])) list.Add(arr[i]);
                }
            }

            int count = list.Count;

            if (count < k)
            {
                for (int i = 0; i < k - count; i++)
                {
                    list.Add(-1);
                }
            }

            return list.ToArray();
        }
    }
}
