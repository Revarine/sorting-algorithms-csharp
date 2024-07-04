using System.Diagnostics;
using System.Collections.Generic;
using array_utility_lib;

namespace bubble;

class Program
{
    public static void BubbleSort(ref int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
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
        BubbleSort(ref arr);
        sw.Stop();
        
        Console.WriteLine("After sorting: ");
        ArrayUtils.PrintArray(arr);
        Console.WriteLine("Sorting time: " + sw.Elapsed);
    }
}