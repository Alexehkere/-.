using System;
class Program{
    static void Main()    
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.4\ConsoleApp4.4\numsTask4.txt");        string[] nums = lines[0].Split(" ");
        int count = 0;
        
        for (int i = 1; i < nums.Length; i++)        
        {
            if (nums[i - 1] == nums[i])            
            {
                count++;            
            }
        }        
        Console.WriteLine(count);    
    }
}