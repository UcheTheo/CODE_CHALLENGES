namespace DATA_STR_ALG;
public class SelectionSortAlgorithm
{
    public static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < arr.Length; j++) 
                if (arr[j] < arr[min]) min = j;

            if (min != i)
                (arr[i], arr[min]) = (arr[min], arr[i]);
        }
    }

}
