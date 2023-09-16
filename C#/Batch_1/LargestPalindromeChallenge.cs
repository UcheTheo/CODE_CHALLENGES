using System;
using System.Collections.Generic;

namespace Batch_1
{
    public class LargestPalindromeChallenge
    {
        /// <summary>
        ///     Checks if a given integer number is a palindrome or not, without converting to string.
        /// </summary>
        /// <remarks>
        ///     A number is a palindrome if when (its digits) reversed, it gives the same original number.
        ///     This is done by walking with half of the value and comparing until the half
        ///     is equal or the half taken to the right, divided by ten, is equal to the other left half
        ///     Examples include: 11, 131, 22422, 9009, etc.
        /// </remarks>
        /// <example>
        ///     Given a number: 22422, the loop goes till half = 224 and num = 22 and exits.
        ///     It then checks if num == half (which is not). It also checks if num == half /10;
        ///     half / 10 = 22 (since it's an integer division, the remainder (4) is cut off).
        ///     So, num(22) = half/10(22), and it returns True.
        /// </example>
        /// <param name="num">The number to check</param>
        /// <returns>A boolean value: True - if it's a palindrome or False - if it's not</returns>
        public static bool IsPalindrome(long num)
        {
            // If number is less than 0 or is divisible by 10 or ends with 0, it's not a palindrome
            if (num < 0 || (num != 0 && num % 10 == 0)) return false;

            long half = 0;

            while (num > half)
            {
                half = (half *  10) + (num % 10);

                num /= 10;
            }

            return (num == half || num == half / 10);
        }

        /// <summary>
        ///     Calculates the value of x raised to n power
        /// </summary>
        /// <remarks>
        ///     The time complexity is: O(log(n)).
        ///     The space complexity is: O(1).
        /// </remarks>
        /// <param name="x">The number to be raised to power</param>
        /// <param name="n">The power to raise the number </param>
        /// <returns>x raised to power n as a double type</returns>
        public static double MyPow(double x, int n)
        {
            // Handles the negative value of n
            if (n < 0)
            {
                n = -1 * n;
                x = 1 / x;
            }
            double pow = 1;

            while (n != 0)
            {
                if (n % 2 != 0) pow *= x;
                if (n == 1) break;
                x *= x;
                n /= 2;
            }
            return pow;
        }

        /// <summary>
        ///     Calculates the Largest Palindrome product of given number of digit num
        /// </summary>
        /// <param name="num">The number of  digits to manipulate</param>
        /// <returns>The largest palindrom product</returns>
        public static long LargestPalindrome(int num)
        {
            long maxNum = (long)MyPow(10, num) - 1;
            long minNum = (maxNum + 1) / 10;
            long largestPalindrome = 0;

            for (long i = maxNum; i >= minNum; i--) 
            {
                for (long j = i; j >= minNum; j--)
                {
                    long prod = i * j;

                    if (prod <= largestPalindrome) break;

                    if (IsPalindrome(prod))
                        largestPalindrome = prod;
                }
            }
            return largestPalindrome;
        }

        /// <summary>
        ///     Calculate the palindrom of a value by first converting to string if it's not a string
        /// </summary>
        /// <typeparam name="T">Generic type parameter</typeparam>
        /// <param name="data">The value to chechk</param>
        /// <returns>True - if palindrome or False - if not palindrome</returns>
        public static bool IsPalindromeStr<T>(T data)
        {
            // Convert data to string if not string
            string? str = data!.ToString();

            // Get half of the length of the str
            double len = Math.Round((double)str!.Length / 2);

            for (int i = 0; i <= len; i++)
            {
                if (str[i] != str[str.Length - 1 - i]) return false;
            }

            return true;
        }


    }
}
