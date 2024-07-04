using System.Diagnostics;
using array_utility_lib;

namespace selection_sort;

class Program
{
    public static void SelectionSort(ref int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i];
            int minIdx = i;

            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIdx])
                {
                    min = arr[j];
                    minIdx = j;
                }
            }

            (arr[minIdx], arr[i]) = (arr[i], arr[minIdx]);
        }
    }

    static void Main(string[] args)
    {
        var arr = new int[1000];
        var sw = new Stopwatch();

        ArrayUtils.FillArray(ref arr);
        Console.WriteLine("Before sorting: ");
        ArrayUtils.PrintArray(arr);

        sw.Start();
        SelectionSort(ref arr);
        sw.Stop();

        Console.WriteLine("After sorting: ");
        ArrayUtils.PrintArray(arr);
        Console.WriteLine("Sorting time: " + sw.Elapsed);
    }
}