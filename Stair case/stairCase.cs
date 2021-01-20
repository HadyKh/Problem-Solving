using System;

class Solution
{
    static void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1-i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = i; k >= 0; k--)
            {
                Console.Write("#");
            }
            Console.Write("\n");
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
        Console.ReadKey();
    }
}
