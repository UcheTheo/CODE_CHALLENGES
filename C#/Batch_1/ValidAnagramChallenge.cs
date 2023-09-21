using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_1
{
    public class ValidAnagramChallenge
    {
        /// <summary>
        ///     Checks if two strings are anagram to each other
        /// </summary>
        /// <param name="str1">First input string</param>
        /// <param name="str2">Second input string</param>
        /// <returns>True - if yes or False - if no</returns>
        public static bool ValidAnagram(string str1, string str2)
        {
            var strFreq = new Dictionary<char, int>();

            foreach (var c in str1)
                strFreq[c] = strFreq.ContainsKey(c) ? strFreq[c] + 1 : 1;

            foreach (var c in str2)
                strFreq[c] = strFreq.ContainsKey(c) ? strFreq[c] - 1 : 1;

            foreach (var entry in strFreq)
                if (entry.Value != 0) return false;
            return true;
        }
    }
}
