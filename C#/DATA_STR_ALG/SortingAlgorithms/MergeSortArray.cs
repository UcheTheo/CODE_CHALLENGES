namespace DATA_STR_ALG;
public class MergeSortArray
{
    public static int[] Merge(int[] arr, int lb, int mid, int ub)
    {
        int i = lb;
        int j = mid + 1;
        int k = lb;
        int[] temp = new int[arr.Length];

        while (i <= mid && j <= ub)
        {
            if (arr[i] <= arr[j])
            {
                temp[k] = arr[i];
                i++;
            }
            else 
            {
                temp[k] = arr[j];
                j++;
            }
            k++;
        }

        if (i > mid)
        {
            while (j <= ub)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }
        }
        else
        {
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
        }

        for (int l = lb; l <= ub; l++)
        {
            arr[l] = temp[l];
        }
            

        return temp;
    }

}
