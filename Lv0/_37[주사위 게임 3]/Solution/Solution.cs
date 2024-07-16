using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int a, int b, int c, int d)
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

        public int solution2(int a, int b, int c, int d)
        {
            var list = new int[4] { a, b, c, d };

            var arr = list.GroupBy(g => g)
                .OrderByDescending(g => g.Count())
                .Select(s => (Number: s.Key, Count: s.Count()))
                .ToArray();

            if (arr[0].Count == 4) return 1111 * arr[0].Number;
            else if (arr[0].Count == 3) return (int)Math.Pow(10 * arr[0].Number + arr[1].Number, 2);
            else if (arr[0].Count == 2)
            {
                if (arr[1].Count == 2) return (arr[0].Number + arr[1].Number) * Math.Abs(arr[0].Number - arr[1].Number);
                else return arr[1].Number * arr[2].Number;
            }
            else return list.Min();
        }

        public int solution3(int a, int b, int c, int d)
        {
            List<int> numbers = new List<int>() { a, b, c, d };
            var groups = numbers.GroupBy(n => n).ToList();

            if (groups.Count == 1) return 1111 * a;

            if(groups.Count == 2)
            {
                if(groups.Any(g => g.Count() == 3))
                {
                    int p = groups.First(g => g.Count() == 3).Key;
                    int q = groups.First(g => g.Count() == 1).Key;
                    return (int)Math.Pow(10 * p + q, 2);
                }
                else
                {
                    int p = groups[0].Key;
                    int q = groups[1].Key;
                    return (p + q) * Math.Abs(p - q);
                }
            }

            if(groups.Count == 3)
            {
                int p = groups.First(g => g.Count() == 2).Key;
                int q = groups.First(g => g.Count() == 1).Key;
                int r = groups.First(g => g.Count() == 1).Key;
                return q * r;
            }

            if (groups.Count == 4) return numbers.Min();

            return 0;
        }
    }
}
