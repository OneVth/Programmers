﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(string[] keyinput, int[] board)
        {
            int[] curPos = new int[2] { 0, 0 };
            int maxX = board[0] / 2;
            int maxY = board[1] / 2;

            foreach (string direction in keyinput)
            {
                int nextPosX = curPos[0];
                int nextPosY = curPos[1];
                switch (direction)
                {
                    case "right":
                        nextPosX++;
                        break;
                    case "left":
                        nextPosX--;
                        break;
                    case "up":
                        nextPosY++;
                        break;
                    case "down":
                        nextPosY--;
                        break;
                }

                if (maxX < Math.Abs(nextPosX))
                    nextPosX = curPos[0];
                if (maxY < Math.Abs(nextPosY))
                    nextPosY = curPos[1];

                curPos[0] = nextPosX;
                curPos[1] = nextPosY;
            }
            return curPos;
        }

        public int[] solution2(string[] keyinput, int[] board)
        {
            int maxX = board[0] / 2;
            int maxY = board[1] / 2;

            int x = 0, y = 0;

            for (int i = 0; i < keyinput.Length; i++)
            {
                switch (keyinput[i])
                {
                    case "left":
                        if (x > -maxX)
                            x--;
                        break;
                    case "right":
                        if (x < maxX)
                            x++;
                        break;
                    case "up":
                        if (y < maxY)
                            y++;
                        break;
                    case "down":
                        if (y > -maxY)
                            y--;
                        break;
                }
            }

            return new int[] { maxX, maxY };
        }
    }
}
