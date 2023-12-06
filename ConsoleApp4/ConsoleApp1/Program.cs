using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i = 3; i <= n; i += 3)
        {
            result *= i;
        }

        Console.WriteLine("Произведение натуральных чисел, кратных трём и не превышающим число n: " + result);
    }
}
