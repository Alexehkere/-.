using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string[] lines = File.ReadAllLines("nums.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers = lines[i].Split(' ');
                lines[i] = string.Join(" ", numbers.Where(number => isEven(number)));
            }

            File.WriteAllLines("nums.txt", lines);
            Console.WriteLine("Четные числа удалены успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }

    static bool isEven(string number)
    {
        if (int.TryParse(number, out int num))
        {
            return num % 2 != 0;
        }

        return true;
    }
}