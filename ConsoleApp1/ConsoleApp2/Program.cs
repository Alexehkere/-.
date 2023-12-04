List<int> nums = new List<int>();
int input;
do
{
    Console.WriteLine("Введите число (введите 0 для завершения): ");
    if (int.TryParse(Console.ReadLine(), out input) && input != 0)
    {
        nums.Add(input);
    }
    else
    {
        Console.WriteLine("Некорректный ввод.");
    }
} while (input != 0);

int sum = 0;
int product = 1;

foreach (int i in nums)
{
    sum += i;
    product *= i;
}

int average = sum / nums.Count;
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Произведение: {product}");
Console.WriteLine($"Среднее: {average}");