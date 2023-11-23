using System;


namespace Batch_1
{
    public class LengthOfLargestSubstChallenge
    {
        public static bool CheckDuplicate(string s, int start, int end)
        {
            int[] result = new int[128];

            for (int i = start; i <= end; i++) 
            {
                char c = s[i];

                result[c] ++;

                if (result[c] > 1)
                {
                    return false;
                }    
            }
            return true;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int largestLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (CheckDuplicate(s, i, j))
                        largestLen = Math.Max(largestLen, j - 1 + 1);
                }
            }
            return largestLen;
        }

        public static int LengthOfLongestSubString(string s)
        {
            var seen = new Dictionary<char, int>();
            int l = 0;
            int length = 0;

            for (int r = 0; r < s.Length; r++)
            {
                char character = s[r];

                if (seen.ContainsKey(character) && seen[character] >= l)
                    l = seen[character] + 1;
                else
                    length = Math.Max(length, r - l + 1);

                seen[character] = r;
            }

            return length;
        }
    }
}
