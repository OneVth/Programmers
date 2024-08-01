using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] arr, int[] delete_list)
        {
            foreach (int i in delete_list)
            {
                arr = arr.Where(w => w != i).ToArray();
            }
            return arr;
        }

        public int[] solution2(int[] arr, int[] delete_list)
        {
            return arr.Where(w => !delete_list.Contains(w)).ToArray();
        }

        public int[] solution3(int[] arr, int[] delete_list)
        {
            return arr.Except(delete_list).ToArray();
        }
    }
}
