using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            return strings.OrderBy(o => o[n]).ThenBy(o => o).ToArray();
        }
    }
}
