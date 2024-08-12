using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string[] spell, string[] dic)
        {
            string sortedSpell = String.Concat(spell.OrderBy(o => o));
            string[] sortedDic = 
                dic.Select(word => new string(word.OrderBy(o => o).ToArray()))
                .ToArray();

            return Array.IndexOf(sortedDic, sortedSpell) > -1 ? 1 : 2;
        }
    }
}
