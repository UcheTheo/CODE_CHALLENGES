using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_1
{
    public class ThreeSumChallenge
    {
        public static List<List<int>> ThreeSum(int[] arr)
        {
            List<List<int>> result = new List<List<int>>();

            if (arr.Length < 3) 
            {
                throw new Exception("Please, input must be an array of not less than three entries");
            }

            Array.Sort(arr);
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) break;

                for (int j = i + 1; j < arr.Length; j++) 
                {
                    for (int k = j + 1; k < arr.Length; k++) 
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            String seq = $"{arr[i]} {arr[j]} {arr[k]}";

                            if (!set.Contains(seq))
                            {
                                List<int> triplet = new List<int>() { arr[i], arr[j], arr[k] };
                                result.Add(triplet);
                                set.Add(seq);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<List<int>> ThreeSumV2(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0) break;

                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int l = i + 1;
                int r = nums.Length - 1;

                while (l < r)
                {
                    int total = nums[i] + nums[l] + nums[r];
                    if (total < 0) l++;
                    else if (total > 0) r--;
                    else
                    {
                        List<int> triplet = new List<int>() { nums[i], nums[l], nums[r] };
                        result.Add(triplet);

                        while (l < r && nums[l] == triplet[1]) l++;
                        while (l < r && nums[r] == triplet[2]) r--;
                    }
                }
            }
            return result;
        }
    }
}
