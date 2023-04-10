using System;
using System.Linq;

namespace LinesAverage
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            double[] lineAverage = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                lineAverage[i] = sum / cols;
                Console.WriteLine($"- {lineAverage[i]:F2}");
            }
        }
    }
}