using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int primarySum = 0;
            int secondarySum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primarySum += matrix[row, col];
                    }
                    if ((row + col) == (size - 1))
                    {
                        secondarySum += matrix[row, col];
                    }
                }
            }
            if (primarySum > secondarySum)
            {
                Console.WriteLine(primarySum - secondarySum);
            }
            else
            {
                Console.WriteLine(secondarySum - primarySum);
            }
        }
    }
}
