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
            var query = array.GroupBy(g => g)
                .OrderByDescending(o => o.Count())
                .Take(2)    // 비교를 위해 앞 두개 선택
                .ToList();

            if (query.Count == 1)
                return query[0].Key;

            return (query[0].Count() != query[1].Count()) ? query[0].Key : -1;
        }
    }
}
