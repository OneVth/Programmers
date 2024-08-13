using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[,] board)
        {
            int n = board.GetLength(0);
            int answer = n * n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 1)
                    {
                        // 위험지역 마킹하기
                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                if (0 <= k && n > k && 0 <= l && n > l && board[k, l] == 0)
                                    board[k, l] = 2;
                            }
                        }
                    }
                }
            }

            // 마킹한 지역 answer에서 빼기
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] != 0)
                        answer--;
                }
            }

            return answer;
        }
    }
}
