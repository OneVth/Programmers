using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluiton
{
    internal class Solution
    {
        public int[] solution(int money)
        {
            return new int[2] { money / 5500, money % 5500 };
        }
    }
}
