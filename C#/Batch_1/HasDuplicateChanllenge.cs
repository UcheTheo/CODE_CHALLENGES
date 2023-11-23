using System.Collections.Generic;

namespace Batch_1
{
    public class HasDuplicateChanllenge
    {
        public static bool HasDuplicate(int[] arr)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Add(arr[i]))
                    return true;
            }
            return false;
        }
    }
}
