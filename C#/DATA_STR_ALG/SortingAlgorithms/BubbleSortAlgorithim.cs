namespace DATA_STR_ALG;
public class BubbleSortAlgorithim
{
    public static void BubbleSortV1(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }

    public static void BubbleSortV2(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }

    public static void BubbleSortV3(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int flag = 0;

            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    flag = 1;
                }
            }

            if (flag == 0) break;
        }
    }
}
