using System;
using System.IO;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllText("numsTask2.txt").Split(';');
        double[] nums = Array.ConvertAll(lines, double.Parse);

        Array.Sort(nums);

        File.WriteAllText("numsTask2.txt", string.Join(";", nums.Select(num => num.ToString())));

        Console.WriteLine("Числа успешно отсортированы");
    }
}