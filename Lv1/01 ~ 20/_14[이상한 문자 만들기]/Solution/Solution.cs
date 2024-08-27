using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] srcArray = s.Split(" ");
            string[] dstArray = new string[srcArray.Length];

            for (int i = 0; i < srcArray.Length; i++)
            {
                for (int j = 0; j < srcArray[i].Length; j++)
                {
                    if (j % 2 == 0)
                        sb.Append(char.ToUpper(srcArray[i][j]));
                    else
                        sb.Append(char.ToLower(srcArray[i][j]));
                }
                dstArray[i] = sb.ToString();
                sb.Clear();
            }

            return String.Join(" ", dstArray);
        }
    }
}
