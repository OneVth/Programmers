using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] strArr)
        {
            return strArr.Where(w => w.IndexOf("ad") == -1).ToArray();
        }
    }
}
