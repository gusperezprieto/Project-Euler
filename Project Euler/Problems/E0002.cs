using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Problems
{
    /// <summary>
    /// Solution to Euler Project Problem 1
    /// https://projecteuler.net/problem=2
    /// https://www.hackerrank.com/contests/projecteuler/challenges/euler002
    /// 
    /// By Gustavo Perez Prieto
    /// https://www.gustavoperez.dev
    /// 
    /// Input Format   
    /// First line contains T that denotes the number of test cases.This is followed by T lines, each containing an integer, N .
    /// 
    /// Constraints
    /// 1 <= T <= 100000
    /// 1 <= N <= 40000000000000000
    /// 
    /// Output Format
    /// 
    /// Print the required answer for each test case.
    /// 
    /// </summary>
    public sealed class E0002 : IEulerInterface
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/contests/projecteuler/challenges/euler002
        /// </summary>
        /// <returns></returns>
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(FibonacciEvenSum(n));

            }
        }

        public static string FibonacciEvenSum(long n)
        {
            long fminus1 = 2;
            long f = 3;
            long total = 2;
            long aux = 0;

            while (true)
            {
                aux = f;
                f = fminus1 + f;
                if (f > n)
                {
                    break;
                }
                fminus1 = aux;
                if (f % 2 == 0)
                {
                    total += f;
                }
            }

            return total.ToString(); 
        }


        /// <summary>
        /// Solution for https://projecteuler.net/problem=2
        /// </summary>
        /// <returns></returns>
        public string Solution()
        {
            long N = 4000000;
            return FibonacciEvenSum(N); 
        }


    }
}
