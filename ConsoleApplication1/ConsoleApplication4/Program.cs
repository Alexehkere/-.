using System;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Server;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число a:");
        int a = Int32.Parse(Console.ReadLine());

        int sum = 0;

        Console.WriteLine("Введите число, при вводе отрицательного числа программа закончит работу: ");
        int num = Int32.Parse(Console.ReadLine());

        while (num >= 0)
        {
            Console.WriteLine("Введите число, при вводе отрицательного числа программа закончит работу: ");
            num = Int32.Parse(Console.ReadLine());
            if (num % a == 0)
            {
                sum += num;
            }
        }

        Console.WriteLine($"Сумма чисел, делящихся на положительное число a нацело: {sum}");
    }
}