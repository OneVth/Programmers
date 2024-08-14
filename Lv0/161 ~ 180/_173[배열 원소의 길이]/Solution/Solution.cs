using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(string[] strlist)
        {
            return strlist.Select(s => s.Length).ToArray(); ;
        }
    }
}
