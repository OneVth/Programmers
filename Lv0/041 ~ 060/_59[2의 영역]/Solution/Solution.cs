﻿using System;
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
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                    list.Add(i);
            }

            if (list.Count == 0) answer = new int[] { -1 };
            else if (list.Count == 1) answer = new int[] { 2 };
            else answer = arr.Skip(list[0]).Take(list[list.Count - 1] - list[0] + 1).ToArray();

            return answer;
        }

        public int[] solution2(int[] arr)
        {
            int start = Array.IndexOf(arr, 2);
            if (start == -1) return new int[1] { -1 };

            int end = Array.LastIndexOf(arr, 2);

            int[] answer = new int[end - start + 1];
            Array.Copy(arr, start, answer, 0, answer.Length);
            return answer;
        }
    }
}
