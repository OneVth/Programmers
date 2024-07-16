using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public bool solution(bool x1, bool x2, bool x3, bool x4)
        {

            return (x1 || x2) && (x3 || x4);
        }
    }
}
