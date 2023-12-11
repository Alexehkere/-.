using System;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Server;


internal class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Введите размер массива: ");
        int n = Int32.Parse(Console.ReadLine());
        double[] array = new double[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-10000, 10000) / 100.0;
        }

        int negativeCount = 0;
        int positiveCount = 0;
        foreach (var num in array)
        {
            if (num >= 0)
            {
                positiveCount++;
            }
            else
            {
                negativeCount++;
            }
        }

        double[] negativeArray = new double[negativeCount];
        double[] positiveArray = new double[positiveCount];

        int j = 0;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] >= 0)
            {
                positiveArray[j] = array[i];
                j++;
            }
            else
            {
                negativeArray[k] = array[i];
                k++;
            }
        }

        Console.WriteLine("Исходный массив");
        foreach (var num in array)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();

        Console.WriteLine("Массив с положительными элементами");
        foreach (var num in positiveArray)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();

        Console.WriteLine("Массив с отрицательными элементами");
        foreach (var num in negativeArray)
        {
            Console.Write($"{num} ");
        }
    }
}