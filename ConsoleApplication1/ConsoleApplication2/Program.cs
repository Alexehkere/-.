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
            string[] lines = File.ReadAllLines("numsTask2.txt");

            string result = string.Join(" ", lines);

            Console.WriteLine(result);

            File.WriteAllText("numsTask2result.txt", result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}