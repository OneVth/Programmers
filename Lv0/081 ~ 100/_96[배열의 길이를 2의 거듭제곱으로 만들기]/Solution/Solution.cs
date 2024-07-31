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
            int n = 1;

            while (n < arr.Length)
                n *= 2;

            int[] answer = new int[n];

            Array.Copy(arr, 0, answer, 0, arr.Length);

            return answer;
        }

        public int[] solution2(int[] arr)
        {
            int a = 1;
            while (a < arr.Length)
                a *= 2;

            Array.Resize(ref arr, a);
            return arr;
        }
    }
}
