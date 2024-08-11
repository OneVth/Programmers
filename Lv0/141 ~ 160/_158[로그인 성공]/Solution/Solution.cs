using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string[] id_pw, string[,] db)
        {
            string answer = "fail";

            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (db[i, 0] == id_pw[0])
                {
                    answer = "wrong pw";
                    if (db[i, 1] == id_pw[1])
                        answer = "login";
                }

            }

            return answer;
        }

        public string solution2(string[] id_pw, string[,] db)
        {
            string answer = "fail";

            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (db[i, 0] == id_pw[0])
                {
                    if (db[i, 1] == id_pw[1])
                        answer = "login";
                    else
                        answer = "wrong pw";
                }
            }
            return answer;
        }
    }
}
