using System;

namespace LotteryTicket
{
    internal class Program
    {
        static void Main()
        {
            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[,] ticket = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    ticket[row, col] = int.Parse(line[col]);
                }
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int abovePrimarySum = 0;
            int belowPrimarySum = 0;
            int evenOnPrimaryCount = 0;
            int evenOnEdgeCount = 0;
            int oddOnEdgeCount = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col)
                    {
                        primaryDiagonalSum += ticket[row, col];
                        if (ticket[row, col] % 2 == 0)
                        {
                            evenOnPrimaryCount++;
                        }
                    }

                    if (row + col == rows - 1)
                    {
                        secondaryDiagonalSum += ticket[row, col];
                    }

                    if (row < col)
                    {
                        abovePrimarySum += ticket[row, col];
                    }

                    if (row > col)
                    {
                        belowPrimarySum += ticket[row, col];
                    }

                    if (row == 0 || row == rows - 1 || col == 0 || col == cols - 1)
                    {
                        if (ticket[row, col] % 2 == 0)
                        {
                            evenOnEdgeCount++;
                        }
                        else
                        {
                            oddOnEdgeCount++;
                        }
                    }
                }
            }

            bool isWinning = primaryDiagonalSum == secondaryDiagonalSum &&
                             abovePrimarySum % 2 == 0 && belowPrimarySum % 2 == 1;

            if (isWinning)
            {
                double prize = (belowPrimarySum + evenOnPrimaryCount + evenOnEdgeCount + oddOnEdgeCount) / 4.0 * 2 - 0.5;
                Console.WriteLine($"YES \nThe amount of money won is: {prize:F2}");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}