using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    /// <summary>
    /// Shared code for solutions to Project Euler problems. 
    /// 
    /// </summary>
    public sealed class EulerLibrary
    {
        /// <summary>
        /// Check id integer is palidrome
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int number)
        {
            int sum = 0;
            int temp = number;
            while (temp > 0)
            {
                sum *= 10;
                sum += temp % 10;
                temp /= 10;
            }
            return (number == sum);

        }

    }
}
