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
            int n = 1;

            while (n < arr.Length)
                n *= 2;

            int[] answer = new int[n];

            Array.Copy(arr, 0, answer, 0, arr.Length);

            return answer;
        }
    }
}
