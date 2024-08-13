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

        public int solution2(int[,] board)
        {
            int n = board.GetLength(0);
            int answer = n * n;

            // Direction vectors for 8 directions
            int[] dx = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] dy = { -1, 0, 1, 1, 1, 0, -1, -1 };

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (board[i, j] == 1)
                    {
                        // Mark the current bomb position as unsafe
                        answer--;
                        for (int d = 0; d < 8; d++)
                        {
                            int ni = i + dx[d];
                            int nj = j + dy[d];
                            if (0 <= ni && ni < n && 0 <= nj && nj < n && board[ni, nj] == 0)
                            {
                                board[ni, nj] = 2; // Mark unsafe area
                                answer--;
                            }

                        }
                    }
                }
            }
            return answer;
        }
    }
}
