using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] str_list)
        {
            List<string> answer = new List<string>();
            int lIndex = Array.IndexOf(str_list, "l");
            int rIndex = Array.IndexOf(str_list, "r");

            if (str_list.Length == 1) return new string[] { };

            if (lIndex == 1) return new string[] { };

            if (lIndex >= 0 && rIndex >= 0)
            {
                if (lIndex < rIndex)
                {
                    for (int i = 0; i < lIndex; i++)
                        answer.Add(str_list[i]);
                }
                else
                {
                    for (int i = rIndex + 1; i < str_list.Length; i++)
                        answer.Add(str_list[i]);
                }
            }
            else if (lIndex >= 0 && rIndex == -1)
            {
                for (int i = 0; i < lIndex; i++)
                    answer.Add(str_list[i]);
            }
            else if (lIndex == -1 && rIndex >= 0)
            {
                for (int i = rIndex + 1; i < str_list.Length; i++)
                    answer.Add(str_list[i]);
            }
            else return new string[] { };


            return answer.ToArray();
        }
    }
}
