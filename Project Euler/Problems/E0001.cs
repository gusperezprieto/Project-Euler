using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Problems
{
    /// <summary>
    /// Solution to Euler Project Problem 1
    /// https://projecteuler.net/problem=1
    /// https://www.hackerrank.com/contests/projecteuler/challenges/euler001
    /// 
    /// By Gustavo Perez Prieto
    /// https://www.gustavoperez.dev
    /// 
    /// Input Format   
    /// First line contains T that denotes the number of test cases.This is followed by T lines, each containing an integer, N .
    /// 
    /// Constraints
    /// 1 <= T <= 100000
    /// 1 <= N <= 1000000000
    /// 
    /// Output Format
    /// 
    /// For each test case, print an integer that denotes the sum of all the multiples of 3 or 5 below N.
    /// 
    /// </summary>
    public sealed class E0001 : IEulerInterface
    {

        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Mult3And5(n - 1);
            }
        }

        /// <summary>
        /// Solution avoiding loops. 
        /// 0(n) = Constant time. 
        /// </summary>
        /// <param name="n"></param>
        private static string Mult3And5(int n)
        {

            if ((n < 0) || (n >= 1000000000))
            {
                throw new Exception("Number out of boundaries");
            }

            long maxMult3 = n - (n % 3);
            long maxMult5 = n - (n % 5);
            long maxMult15 = n - (n % 15); ;

            long numMult3 = maxMult3 / 6;
            long numMult5 = maxMult5 / 10;
            long numMult15 = maxMult15 / 30;

            long totalMult3 = n >= 3 ? (maxMult3 + 3) * (numMult3) + (maxMult3 % 2) * (maxMult3 + 3) / 2 : 0;
            long totalMult5 = n >= 5 ? (maxMult5 + 5) * (numMult5) + (maxMult5 % 2) * (maxMult5 + 5) / 2 : 0;
            long totalMult15 = n >= 15 ? (maxMult15 + 15) * (numMult15) + (maxMult15 % 2) * (maxMult15 + 15) / 2 : 0;

            Console.WriteLine(totalMult3 + totalMult5 - totalMult15);

            return totalMult3 + totalMult5 - totalMult15 + ""; 

        }


        /// <summary>
        /// Solution for https://projecteuler.net/problem=1
        /// </summary>
        /// <returns></returns>
        public string Solution()
        {
            int N = 1000;
            return Mult3And5(N-1); 
        }
    }
}
