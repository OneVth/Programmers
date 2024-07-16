using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int a, int b, int c, int d)
        {
            int[] counts = new int[7];
            List<int> uniqueNumbers = new List<int>();
            List<int> frequencies = new List<int>();

            counts[a]++;
            counts[b]++;
            counts[c]++;
            counts[d]++;

            for (int i = 1; i <= 6; i++)
            {
                if (counts[i] > 0)
                {
                    uniqueNumbers.Add(i);
                    frequencies.Add(counts[i]);
                }
            }

            // All four numbers are the same
            if (frequencies.Count == 1) return 1111 * a;

            if (frequencies.Count == 2)
            {
                if (frequencies.Contains(3))
                {
                    // Three numbers the same
                    int p = uniqueNumbers[frequencies.IndexOf(3)];
                    int q = uniqueNumbers[frequencies.IndexOf(1)];

                    return (int)Math.Pow(10 * p + q, 2);
                }
                else
                {
                    // Two pairs of numbers
                    int p = uniqueNumbers[0];
                    int q = uniqueNumbers[1];

                    return (p + q) * Math.Abs(p - q);
                }
            }

            if (frequencies.Count == 3)
            {
                // Two numbers the same and two different
                int p = uniqueNumbers[frequencies.IndexOf(2)];
                int q = uniqueNumbers[frequencies.IndexOf(1)];
                int r = uniqueNumbers[frequencies.LastIndexOf(1)];
                return q * r;
            }

            if (frequencies.Count == 4) return Math.Min(Math.Min(a, b), Math.Min(c, d));

            return 0;
        }
    }
}
