namespace DATA_STR_ALG;
public class QuickSortAlgorithm
{

    public static void QuickSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int pivot = Partition.PartitionV3(arr, start, end);

            QuickSort(arr, start, pivot - 1);

            QuickSort(arr, pivot + 1, end);
        }
    }

}
