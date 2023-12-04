Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();

int wordCount = 0;

string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
wordCount = words.Length;

string newStr = $"Start {str} End";
Console.WriteLine($"Количество слов в строке: {wordCount}");
Console.WriteLine($"Измененная строка: {newStr}");
