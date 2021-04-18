using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Solution to Euler Project Problem 3
/// https://projecteuler.net/problem=3
/// https://www.hackerrank.com/contests/projecteuler/challenges/euler003
/// 
/// By Gustavo Perez Prieto
/// https://www.gustavoperez.dev
/// 
/// Input Format   
/// First line contains T that denotes the number of test cases.This is followed by T lines, each containing an integer, N .
/// 
/// Constraints
/// 1 <= T <= 10
/// 10 <= N <= 1000000000000
/// 
/// Output Format
/// 
/// For each test case, display the largest prime factor of N. 
/// 
/// ----------------------
/// 
/// By the fundamental theorem of arithmetic, every integer n > 1 has a unique factorization as a product of prime numbers.
/// 
/// </summary>
namespace Project_Euler.Problems
{
    public sealed class E0003 : IEulerInterface
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/contests/projecteuler/challenges/euler003
        /// </summary>
        /// <returns></returns>
        static void Main()
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(GetLargestPrimeFactor(n));
            }
        }

        private static string GetLargestPrimeFactor(long N)
        {
            if (N <= 3)
            {
                return N.ToString(); 
            }

            N = ReduceNumber(N, 2);

            if (N == 1)
            {
                return "2";
            }

            long largestPrimeFactor = 1;


            for (int i = 3; i <= Math.Sqrt(N); i += 2)
            {

                if (N % i == 0)
                {
                    N = ReduceNumber(N, i);
                    if (N == 1)
                    {
                        largestPrimeFactor = i;
                        break;
                    }
                }
            }

            if (N > 2)
            {
                largestPrimeFactor = N;
            }

            return largestPrimeFactor.ToString(); 
        }

        private static long ReduceNumber(long n, long p)
        {
            long response = n;
            while (response % p == 0)
            {
                response /= p;
            }
            return response;
        }
        /// <summary>
        /// Solution for https://projecteuler.net/problem=3
        /// </summary>
        /// <returns></returns>
        public string Solution()
        {
            long N = 600851475143L;
            return GetLargestPrimeFactor(N); 
        }
    }
}
