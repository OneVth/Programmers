using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();
            List<string> banned = new List<string>();

            for (int i = 0; i < id_list.Length; i++)
            {
                dict.Add(id_list[i], new HashSet<string>());
            }

            // 신고한 유저 HashSet에 담기
            for (int i = 0; i < report.Length; i++)
            {
                string[] temp = report[i].Split();
                dict[temp[0]].Add(temp[1]);
            }

            // 신고당한 유저 정지
            for (int i = 0; i < id_list.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < id_list.Length; j++)
                {
                    HashSet<string> tempHashSet = dict[id_list[j]];

                    if (dict[id_list[j]].Contains(id_list[i]))
                        count++;
                }

                if (count >= k)
                    banned.Add(id_list[i]);
            }

            // 받을 메일 수
            for (int i = 0; i < id_list.Length; i++)
            {
                HashSet<string> tempHash = dict[id_list[i]];

                foreach (string s in banned)
                {
                    if (dict[id_list[i]].Contains(s))
                        answer[i]++;
                }
            }

            return answer;
        }
    }
}
