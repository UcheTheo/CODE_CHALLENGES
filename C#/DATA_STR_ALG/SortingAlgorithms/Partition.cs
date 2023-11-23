namespace DATA_STR_ALG;
public class Partition
{

    public static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    public static int PartitionV3(int[] arr, int lb, int ub)
    {
        int pivot = arr[lb];
        int start = lb;
        int end = ub;

        while (start < end)
        {
            while (start < arr.Length && arr[start] <= pivot) start++;
            while (arr[end] > pivot) end--;

            if (start < end)
                (arr[start], arr[end]) = (arr[end], arr[start]);
                //Swap(arr, start, end);
        }
        (arr[lb], arr[end]) = (arr[end], arr[lb]);

        //Swap(arr, lb, end);
        return end;
    }

    public static int PartitionV4(int[] arr, int start, int end)
    {
        int pivot = arr[end];

        int i = (start - 1);

        for (int j = start; j <= end; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[end]) = (arr[end], arr[i + 1]);
        return (i + 1);
    }

    public static int PartitionV5(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int k = high;

        for (int i = high; i > low; i--)
        {
            if (arr[i] > pivot) 
            {
                //Swap(arr, i, k--);
                (arr[i], arr[k]) = (arr[k], arr[i]);
                k--;
            }
        }

        //Swap(arr, low, k);
        (arr[low], arr[k]) = (arr[k], arr[low]);

        return k;
    }

}
