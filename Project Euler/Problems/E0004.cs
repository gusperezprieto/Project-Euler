using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Problems
{
    /// <summary>
    /// Solution to Euler Project Problem 3
    /// https://projecteuler.net/problem=4
    /// https://www.hackerrank.com/contests/projecteuler/challenges/euler004
    /// 
    /// By Gustavo Perez Prieto
    /// https://www.gustavoperez.dev
    /// 
    /// Input Format   
    /// First line contains T that denotes the number of test cases.This is followed by T lines, each containing an integer, N .
    /// 
    /// Constraints
    /// 1 <= T <= 10
    /// 101101 < N < 1000000
    /// 
    /// Output Format
    /// 
    /// Print the required answer for each test case in a new line.
    /// 
    /// </summary>
    public sealed class E0004
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/contests/projecteuler/challenges/euler004
        /// </summary>
        /// <returns></returns>
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(MaxPalindrome(n));
            }
        }

        private static int MaxPalindrome(int n)
        {
            int response = 0;

            for (int i = 0; i <= 999; i++)
            {
                //for (int j = i; j <= 999; j++)
                for (int j = i; j <= 999; j++)
                {
                    int auxMult = i * j;
                    if (auxMult >= n)
                    {
                        break;
                    }
                    if (EulerLibrary.IsPalindrome(auxMult) && auxMult > response)
                    {
                        response = auxMult;
                    }
                }

            }

            return response;
        }

        /// <summary>
        /// Solution for https://projecteuler.net/problem=3
        /// </summary>
        /// <returns></returns>
        public string Solution()
        {
            int N = 999 * 999;
            return MaxPalindrome(N).ToString(); 
        }
    }
}
