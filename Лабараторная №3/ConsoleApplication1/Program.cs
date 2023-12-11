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
            string[] lines = File.ReadAllLines("input.txt");
            int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();
            int numberOfTickets = int.Parse(lines[1]);
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 2; i < 2 + numberOfTickets; i++)
                {
                    int[] ticketNumbers = lines[i].Split(' ').Select(int.Parse).ToArray();
                    int matches = ticketNumbers.Intersect(chosenNumbers).Count();

                    writer.WriteLine(matches >= 3 ? "Lucky" : "Unlucky");
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
