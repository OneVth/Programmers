using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] array, int[,] commands)
        {
            int i, j, k;
            int length;
            int[] answer = new int[commands.GetLength(0)];

            for (int r = 0; r < commands.GetLength(0); r++)
            {
                i = commands[r, 0] - 1;
                j = commands[r, 1] - 1;
                k = commands[r, 2] - 1;
                length = j - i + 1;
                int[] temp = new int[length];

                Array.Copy(array, i, temp, 0, length);
                answer[r] = temp.OrderBy(o => o).ToArray()[k];
            }

            return answer;
        }

        public int[] solution2(int[] array, int[,] commands)
        {
            int i, j, k;
            int length;
            int[] answer = new int[commands.GetLength(0)];

            for(int r = 0; r < commands.GetLength(0); r++)
            {
                i = commands[r, 0] - 1;
                j = commands[r, 1] - 1;
                k = commands[r, 2] - 1;
                length = j - i + 1;

                answer[r] = array.Skip(i).Take(length).OrderBy(o => o).ToArray()[k];
            }

            return answer;
        }
    }
}
