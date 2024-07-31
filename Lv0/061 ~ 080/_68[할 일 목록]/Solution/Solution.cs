using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution1(string[] todo_list, bool[] finished)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < finished.Length; i++)
                if (finished[i] == false)
                    list.Add(todo_list[i]);

            return list.ToArray();
        }

        public string[] solution2(string[] todo_list, bool[] finished)
        {
            return todo_list.Where((w, index) => !finished[index]).ToArray();
        }
    }
}
