using System;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Server;


internal class Program
{
    public static void Main(string[] args)
    {

        try
        {
            string[] words = File.ReadAllText("numsTask1.txt").Split(' ').ToArray();

            foreach (var word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.Write($"{word} ");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}