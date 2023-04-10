using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n][];

            for (int row = 0; row < n; row++)
            {
                triangle[row] = new int[row + 1];
                triangle[row][0] = 1;
                triangle[row][row] = 1;
                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < n - row - 1; i++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write(triangle[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}