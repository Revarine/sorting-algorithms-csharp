using System.Diagnostics;
using System.Collections.Generic;

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

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }

        Console.WriteLine();
    }

    public static void FillArray(ref int[] arr)
    {
        var rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 1000);
        }
    }

    static void Main(string[] args)
    {
        var arr = new int[1000];
        var sw = new Stopwatch();

        FillArray(ref arr);
        Console.WriteLine("Before sorting: ");
        PrintArray(arr);

        sw.Start();
        BubbleSort(ref arr);
        sw.Stop();
        
        Console.WriteLine("After sorting: ");
        PrintArray(arr);
        Console.WriteLine("Sorting time: " + sw.Elapsed);
    }
}