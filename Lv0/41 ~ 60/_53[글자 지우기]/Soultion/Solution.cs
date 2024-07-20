using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soultion
{
    internal class Solution
    {
        public string solution(string my_string, int[] indices)
        {
            StringBuilder sb = new StringBuilder(my_string);

            Array.Sort(indices);
            Array.Reverse(indices);

            foreach (int i in indices)
            {
                sb.Remove(i, 1);
            }

            return sb.ToString();
        }
    }
}
