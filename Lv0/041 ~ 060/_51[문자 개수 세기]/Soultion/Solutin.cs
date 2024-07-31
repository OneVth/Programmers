using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soultion
{
    internal class Solutin
    {
        public int[] solution1(string my_string)
        {
            char[] chars = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] answer = new int[chars.Length];

            foreach (char c in my_string)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (c == chars[i]) answer[i] += 1;
                }
            }

            return answer;
        }

        public int[] solution2(string my_string)
        {
            // 52 : Uppercase(26) + lowercase(26) English letter
            int[] answer = new int[52];

            foreach(char c in my_string)
            {
                // 'A' has an ASCII value of 65
                if (Char.IsUpper(c)) answer[c - 'A']++;
                // 'a' has an ASCII value of 97
                else answer[26 + c - 'a']++;
            }

            return answer;
        }
    }
}
