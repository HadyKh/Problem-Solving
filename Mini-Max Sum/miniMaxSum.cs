using System;

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        Array.Sort(arr);
        Int64 max = 0;
        Int64 min = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            max += arr[i];
        }
        for (int i = arr.Length-2; i >= 0; i--)
        {
            min += arr[i];
        }
        Console.Write(min + " " + max);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);

        Console.ReadKey();
    }
}
