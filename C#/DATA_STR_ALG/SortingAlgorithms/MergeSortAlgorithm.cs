namespace DATA_STR_ALG;
public class MergeSortAlgorithm
{
    public static void MergeSort(int[] arr, int lb, int ub)
    {
        if (lb < ub)
        {
            int mid = (lb + ub) / 2;

            MergeSort(arr, lb, mid);
            MergeSort(arr, mid + 1, ub);
            MergeSortArray.Merge(arr, lb, mid, ub);
        }

    }
}
