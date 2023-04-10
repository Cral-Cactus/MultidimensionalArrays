using System;

namespace MaxPitch
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, rows];

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            int maxSum = int.MinValue;
            int maxRow = -1, maxCol = -1;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
        }
    
    }
}