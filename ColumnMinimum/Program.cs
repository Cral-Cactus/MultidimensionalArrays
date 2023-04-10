using System;

namespace ColumnMinimum
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(elements[col]);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            int[] columnMin = new int[cols];
            for (int i = 0; i < columnMin.Length; i++)
            {
                columnMin[i] = int.MaxValue;
            }
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < columnMin[col])
                    {
                        columnMin[col] = matrix[row, col];
                    }
                }
            }

            foreach (int min in columnMin)
            {
                Console.Write($"{min} ");
            }
        }
    }
}