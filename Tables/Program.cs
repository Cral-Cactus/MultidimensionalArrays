using System;
using System.Linq;

namespace Tables
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][][] sheets = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int rows = size[0];
                int cols = size[1];
                sheets[i] = new int[rows][];
                for (int row = 0; row < rows; row++)
                {
                    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    sheets[i][row] = values;
                }
            }
            double[] sheetAverages = new double[n];
            for (int i = 0; i < n; i++)
            {
                int min = sheets[i][0][0];
                int max = sheets[i][0][0];
                int sum = 0;

                for (int row = 0; row < sheets[i].Length; row++)
                {
                    for (int col = 0; col < sheets[i][row].Length; col++)
                    {
                        int value = sheets[i][row][col];

                        if (value < min)
                        {
                            min = value;
                        }

                        if (value > max)
                        {
                            max = value;
                        }

                        sum += value;
                    }
                }
                double average = (double)sum / (sheets[i].Length * sheets[i][0].Length);
                sheetAverages[i] = average;
                Console.WriteLine($"{min} {max} {Math.Round(average,2)}");
            }

            double documentAverage = sheetAverages.Average();
            for (int i = 0; i < sheetAverages.Length; i++)
            {
                if (sheetAverages[i] > documentAverage)
                {
                    Console.Write("2 ");
                }
                else
                {
                    Console.Write("4 ");
                }
            }
            Console.WriteLine();

        }
    }
}