using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(int a, int b)
        {
            string answer = "";
            int totalDays = 0;
            int[] nDays = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // 1월 1일로부터 지난 일수 구하기
            for (int i = 0; i < a - 1; i++)
                totalDays += nDays[i];

            totalDays += b - 1;

            // 요일 구하기
            switch (totalDays % 7)
            {
                case 0:
                    answer = "FRI";
                    break;
                case 1:
                    answer = "SAT";
                    break;
                case 2:
                    answer = "SUN";
                    break;
                case 3:
                    answer = "MON";
                    break;
                case 4:
                    answer = "TUE";
                    break;
                case 5:
                    answer = "WED";
                    break;
                case 6:
                    answer = "THU";
                    break;
            }

            return answer;
        }

        public string solution2(int a, int b)
        {
            int totalDays = 0;
            string[] weekName = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
            int[] nDays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // 1월 1일로부터 지난 일수 구하기
            for (int i = 0; i < a - 1; i++)
                totalDays += nDays[i];

            totalDays += b - 1;

            // 요일 구하기
            return weekName[totalDays % 7];
        }

        public string solution3(int a, int b)
        {
            string answer = "";

            DateTime dateValue = new DateTime(2016, a, b);
            answer = dateValue.DayOfWeek.ToString().Substring(0, 3).ToUpper();

            return answer;
        }
    }
}
