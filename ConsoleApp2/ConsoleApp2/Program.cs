namespace ConsoleApp1;

public class Program{
    static void Main()
    {
        Console.WriteLine("Введите размер массива");
        int massArray = Convert.ToInt32(Console.ReadLine());
        int[] mass = new int [massArray];
        
        for (int i = 0, j = 1; i < massArray; i++, j += 2)
        {
            
            mass[i] = j;
        }
        Console.WriteLine("Заполненный массив");
        for (int i = 0; i < massArray; i++)
        {
            Console.WriteLine(mass[i]);
        }
    }
}