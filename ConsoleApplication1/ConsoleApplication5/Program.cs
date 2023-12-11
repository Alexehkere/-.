using System;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Server;


internal class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Введите количество строк матрицы:");
        int n = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов матрицы:");
        int m = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(0, 2);
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }

        int[,] newMatrix = new int[n, m + 1];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
            {
                newMatrix[i, n + 2] = 0;
            }
            else
            {
                newMatrix[i, n + 2] = 1;
            }

            count = 0;
        }

        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write($"{newMatrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}