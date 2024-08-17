using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string letter)
        {
            // a ~ z
            string[] morse =
            {
            ".-", "-...", "-.-.", "-..", ".", "..-.",
            "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", ".--.", "--.-", ".-.",
            "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--.."
        };

            StringBuilder sb = new StringBuilder();
            string[] token = letter.Split(' ');

            for (int i = 0; i < token.Length; i++)
            {
                sb.Append((char)(Array.IndexOf(morse, token[i]) + 'a'));
            }
            return sb.ToString();
        }
    }
}
