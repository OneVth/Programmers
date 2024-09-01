using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] nums)
        {
            int answer = 0;
            bool[] primes = Enumerable.Repeat(true, 3000).ToArray(); ;

            // primes 구하기 (에라토스테네스의 체)
            for (int i = 2; i * i <= 3000; i++)
            {
                if (primes[i])
                {
                    for (int j = i + i; j < 3000; j += i)
                        primes[j] = false;
                }
            }

            // 경우의 수 구하기
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (primes[sum])
                            answer++;
                    }
                }
            }

            return answer;
        }

        public int solution2(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (CheckPrime(sum))
                            answer++;
                    }
                }
            }
            return answer;
        }

        public bool CheckPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
