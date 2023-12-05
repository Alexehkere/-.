namespace ConsoleApp1;

public class Program
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            array[0, i] = 1; 
            array[i, 0] = 1;
        }
        
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                array[i, j] = array[i, j - 1] + array[i - 1, j];
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]} \t ");
            }
            Console.WriteLine();
        }
        
    }
}