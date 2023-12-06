using System;
class Program{
    static void Main()    
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_gokse\Desktop\kirill\ConsoleApp1.4\ConsoleApp4.3\numsTask3.txt");        string[] nums = lines[0].Split(",");
        int min = int.MaxValue;
        int max = int.MinValue;
        foreach (string number in nums)       
        {
            int num = int.Parse(number);            
            if (num == 0)           
            {
                break;            
            }
            if (num < min)
            {                
                min = num;
            }
            if (num > max)            
            {
                max = num;
            }
        }
        float numer = (float)min / max;
        Console.WriteLine(numer);
    }
}