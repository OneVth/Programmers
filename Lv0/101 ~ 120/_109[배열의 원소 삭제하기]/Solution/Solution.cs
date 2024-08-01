using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] arr, int[] delete_list)
        {
            foreach (int i in delete_list)
            {
                arr = arr.Where(w => w != i).ToArray();
            }
            return arr;
        }
    }
}
