using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string letter)
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

        public string solution2(string letter)
        {
            // Initialize a dictionary for Morse code to letter mapping
            var morseDict = new Dictionary<string, char>
            {
                {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'}, {".", 'e'},
                {"..-.", 'f'}, {"--.", 'g'}, {"....", 'h'}, {"..", 'i'}, {".---", 'j'},
                {"-.-", 'k'}, {".-..", 'l'}, {"--", 'm'}, {"-.", 'n'}, {"---", 'o'},
                {".--.", 'p'}, {"--.-", 'q'}, {".-.", 'r'}, {"...", 's'}, {"-", 't'},
                {"..-", 'u'}, {"...-", 'v'}, {".--", 'w'}, {"-..-", 'x'}, {"-.--", 'y'},
                {"--..", 'z'}
            };

            StringBuilder sb = new StringBuilder();
            string[] token = letter.Split(" ");

            foreach(string morseChar in token)
            {
                if(morseDict.TryGetValue(morseChar, out char letterChar))
                    sb.Append(letterChar);
            }

            return sb.ToString();
        }
    }
}
