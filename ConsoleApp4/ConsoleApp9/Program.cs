using System.Globalization;

namespace Program5{
    class Program5    
    {
        public static void Main()        
        {
            Console.WriteLine("Введите число x: ");            float numX = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Введите число y: "); 
            float numY = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
            if (( ((numY - 2) / 2.5f) <= numX && ((numY - 2) / -2.5f) >= numX ) && (numY >= -3 && numY <= 2))             
            {
                Console.WriteLine("Точка входит в эту область");            
            }
            else            
            {
                Console.WriteLine("Точка не входит в эту область");            
            }
        }    
    }
}