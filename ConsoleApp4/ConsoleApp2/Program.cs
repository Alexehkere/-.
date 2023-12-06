using System;
class Program{
    static void Main()   
    {
        string pathInput = (@"C:\Users\public\Desktop\kirill\ConsoleApp1.4\ConsoleApp4.2\numsTask2.txt");        float[] nums;
        StreamReader readTask2 = new StreamReader(pathInput);        string[] input = readTask2.ReadLine().Split(";");
        nums = new float[input.Length];
        for (int i = 0; i < input.Length; i++)        
        {
            nums[i] = float.Parse(input[i]);
            
        }
        float sum = 0;
        for (int i = 0; i < nums.Length; i++)       
        {
            if (nums[i] == 0)
            {                
                Console.WriteLine(sum);
            } 
            else
            { 
                if (nums[i] > 0)
            {  
                sum = nums[i] + sum;
            }            
            }
        }
    }
    
}