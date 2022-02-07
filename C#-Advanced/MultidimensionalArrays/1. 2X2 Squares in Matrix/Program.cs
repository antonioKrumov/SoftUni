using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int squareMatrixes = 0; 
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string elementToCompare = matrix[row, col];
                    if (elementToCompare == matrix[row, col + 1] && elementToCompare == matrix[row + 1, col] && elementToCompare == matrix[row + 1, col + 1])
                    {
                        squareMatrixes++;
                    }
                }
            }
            Console.WriteLine(squareMatrixes);
        }
    }
}
