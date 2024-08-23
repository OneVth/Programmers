using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] array)
        {
            Array.Sort(array);

            return array[array.Length / 2]; ;
        }
    }
}
