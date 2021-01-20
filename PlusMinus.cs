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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        decimal pve = 0;
        decimal nve = 0;
        decimal zero = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                pve ++;
            else if (arr[i] < 0)
                nve ++;
            else
            {
                zero++;
            }
        }
        pve = pve/arr.Length;
        nve = nve / arr.Length;
        zero = zero / arr.Length;
        Console.WriteLine(pve.ToString("N6")+"\n"+nve.ToString("N6")+"\n"+zero.ToString("N6"));

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
        Console.ReadKey();
    }
}
