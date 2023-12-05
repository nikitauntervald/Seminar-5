using System.Globalization;
using System;
class Program
{
    static void Main()
    {
        void ShowIntMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                Console.Write($"row[{rows}]: ");
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    Console.Write($"[{matrix[rows, columns]}] ");
                }
                Console.WriteLine();
            }
        }


        int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
        {
            int[,] result = new int[rows, columns];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = rnd.Next(min, max + 1);
                }
            return result;
        }


        int GetRowWithMinElem(int[,] array)
        {
            int min = int.MaxValue;
            int minRow = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                if (sum < min)
                {
                    min = sum;
                    minRow = i;
                }
            }
            return minRow;
        }



        Console.Clear();
        Console.Write($"Enter rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter min: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter max: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int[,] array = CreateRandomMatrix(rows, cols, min, max);
        ShowIntMatrix(array);

        Console.WriteLine($"Row with index {GetRowWithMinElem(array)}");
    }
}
