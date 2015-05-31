using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cinema_Seats
{ 
    class cinema
    {
        //function that finds the row with the least zeroes 
        static void leastZeroes(int[,] ourMatrix)
        {
            int largestSumOfOnes = 0;
            int[] sumOfIntsPerRow = new int[20];
            int sum = 0;
            for(int row=0; row<ourMatrix.GetLength(0);row++)
            {
                for (int col = 0; col < ourMatrix.GetLength(1);col++)
                {
                    sum = ourMatrix[row, col];
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            // Read the matrix dimensions
            Console.Write("Number of rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of columns = ");
            int cols = int.Parse(Console.ReadLine());

            // Allocate the matrix
            int[,] matrix = new int[rows, cols];

            // Enter the matrix elements
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    int element = int.Parse(Console.ReadLine());
                    matrix[row, col] = element;
                }
            }

            leastZeroes(matrix);
        }
    }
}
