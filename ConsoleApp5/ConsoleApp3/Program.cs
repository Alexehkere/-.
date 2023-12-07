using System;
using System.IO;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int[] nums = File.ReadAllText("numsTask3.txt").Split(' ').Select(int.Parse).ToArray();

            int minIndex = Array.IndexOf(nums, nums.Min());

            int sum = 0;
            for (int i = 0; i < minIndex; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine($"Среднее арифметическое элементов расположенных до минимального: {sum / minIndex}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;

        }
    }
    
}