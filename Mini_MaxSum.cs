using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
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
