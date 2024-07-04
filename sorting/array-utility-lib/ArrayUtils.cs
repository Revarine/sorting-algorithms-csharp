namespace array_utility_lib;

public class ArrayUtils
{
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
}