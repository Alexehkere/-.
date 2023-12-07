using System;
using System.IO;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {


        try
        {
            int[] nums = File.ReadAllText("numsTask1.txt").Split(' ').Select(int.Parse).ToArray();

            int minIndex = Array.IndexOf(nums, nums.Min());

            int product = 1;
            for (int i = minIndex + 1; i < nums.Length; i++)
            {
                product *= nums[i];
            }

            Console.WriteLine($"Произведение элементов после минимального: {product}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }

    }
}

