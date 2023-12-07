using System;
using System.IO;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int[] nums = File.ReadAllText("numsTask4.txt").Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Max() - nums[i] == 1)
                {
                    sum += nums[i];
                }
            }

            Console.WriteLine($"Сумма элементов, отличающихся от максимального от 1: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
    }
}