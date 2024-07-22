using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution1(string[] str_list)
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

        public string[] solution2(string[] str_list)
        {
            int l = Array.IndexOf(str_list, "l");
            int r = Array.IndexOf(str_list, "r");

            return (l == -1 && r == -1) ? new string[] { } : 
                ((l == -1 ? r + 1 : l) < (r == -1 ? l + 1 : r) ? str_list.Take(l).ToArray() : 
                str_list.Skip(r + 1).ToArray());
        }

        public string[] solution3(string[] str_list)
        {
            var list = new List<string>();

            bool isFirst = false;
            foreach (var c in str_list)
            {
                if (!isFirst)
                {
                    if (c == "l") return list.ToArray();
                    else if (c == "r")
                    {
                        list.Clear();
                        isFirst = true;
                        continue;
                    }
                }

                list.Add(c);
            }

            return isFirst ? list.ToArray() : new string[] { };
        }
    }
}
