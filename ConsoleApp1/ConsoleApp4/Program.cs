Console.WriteLine("Введите начало диапазона: ");
int startRange = int.Parse(Console.ReadLine());
        
Console.WriteLine("Введите конец диапазона: ");
int endRange = int.Parse(Console.ReadLine());

List<int> randomNums = GenerateRandomNums(startRange, endRange);
        
Console.Write("Элементы массива: ");
foreach (var i in randomNums)
{
    Console.Write($"{i} ");
}



static List<int> GenerateRandomNums(int startRange, int endRange)
{
    List<int> randomNums = new List<int>();
    Random random = new Random();

    int amountElements = 10;
    for (int i = 0; i < amountElements; i++)
    {
        int randomNum = random.Next(startRange, endRange + 1); 
        randomNums.Add(randomNum);
    }

    return randomNums;
}
