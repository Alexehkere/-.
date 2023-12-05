namespace ConsoleApp1;

public class Program{
    static void Main() 
    {
        int massArray = 100;
        int[] mass = new int [massArray];
        for (int i = 0; i < massArray; i++)
        {
            mass[i] =  (massArray * 3) - (i * 3);
        }
        Console.WriteLine("Заполненный массив");
        for (int i = 0; i < massArray; i++)
        {
            Console.WriteLine(mass[i]);
        }
    }
}