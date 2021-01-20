using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        private static int n;
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int x = diagonalDifference(arr);
            Console.WriteLine(x);

            Console.ReadKey();

        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int x = 0;
            int y = 0;
            int l = 2;
            int j = n-1;
            for (int i = 0; i < n; i++)
            {
                x += arr[i][i];
                y += arr[i][j--];
            }
            return Math.Abs(x - y);
        }
    }
}
