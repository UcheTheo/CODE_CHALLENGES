using System;

namespace Batch_1
{
    public class ProdArrayExceptSelf
    {
        public static int[] ProdArr(int[] arr)
        {
            int[] res = new int[arr.Length];
            int resFirstEntry = 1;

            for (int i = 1; i < arr.Length; i++) 
            {
                resFirstEntry *= arr[i];
            }

            res[0] = resFirstEntry;
            

            for (int i = 1; i < arr.Length; i++)
            {
                res[i] = (resFirstEntry / arr[i]) * arr[0];
            }

            return res;
        }

        public static int[] ProdArrV2(int[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int[] res = new int[arr.Length];

            left[0] = 1;
            right[arr.Length - 1] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                left[i] = arr[i - 1] * left[i - 1] ;
            }

           
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                right[i] = arr[i + 1] * right[i + 1];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = left[i] * right[i];
            }

            return res;
        }

        public static int[] ProdArrV3(int[] arr)
        {
            int[] res = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                res[i] = 1;

            for (int i = 1; i < arr.Length; i++)
                res[i] = arr[i - 1] * res[i - 1];


            int right = arr[^1];

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                res[i] *= right;
                right *= arr[i];
            }

            return res;
        }

    }
}
