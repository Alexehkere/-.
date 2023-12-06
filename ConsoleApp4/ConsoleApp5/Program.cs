using System;
class Program{
    static void Main()    {
        Console.WriteLine("Введите точку x");        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите точку y");        int y = Convert.ToInt32(Console.ReadLine());
        if (x >= -1 && x <= 3 && y >= -2 && y <= 4)
        {            Console.WriteLine($"Точки  {x}  {y} принадлежат заштрихованной области ");
        }        else
        {
            Console.WriteLine($"Точки  {x}  {y} не принадлежат заштрихованной области ");        }
    }}