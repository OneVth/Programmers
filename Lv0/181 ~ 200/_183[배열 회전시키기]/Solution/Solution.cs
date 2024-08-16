using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] numbers, string direction)
        {
            List<int> list = new List<int>();
            list.AddRange(numbers);

            switch (direction)
            {
                case "right":
                    list.Insert(0, list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                    break;
                case "left":
                    list.Add(list[0]);
                    list.RemoveAt(0);
                    break;
            }

            return list.ToArray();
        }
    }
}
