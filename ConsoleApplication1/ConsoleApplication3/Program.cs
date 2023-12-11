using System;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Server;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int num = Int32.Parse(Console.ReadLine());
        if (num % 10 == 0)
        {
            Console.WriteLine("Число четное и кратное 10");
        }
        else
        {
            Console.WriteLine("Число не четное и не кратное 10");
        }
    }
}