using System;

class Program
{
    static void Main()
    {
        // Создание массива для хранения температур
        double[,] temperature = new double[12, 30];

        // Заполнение массива случайными значениями температур
        Random rand = new Random();
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                // Генерация случайной температуры в диапазоне от -10 до 35 (в пределах разумного)
                temperature[month, day] = rand.NextDouble() * (35 - (-10)) + (-10);
            }
        }

        // Вычисление средних температур для каждого месяца
        double[] averageTemperatures = CalculateAverageTemperatures(temperature);

        // Сортировка массива средних температур по возрастанию
        Array.Sort(averageTemperatures);

        // Вывод средних температур по возрастанию
        Console.WriteLine("Средние температуры по возрастанию:");
        foreach (var avgTemp in averageTemperatures)
        {
            Console.WriteLine(avgTemp);
        }
    }

    // Метод для вычисления средних температур для каждого месяца
    static double[] CalculateAverageTemperatures(double[,] temperatures)
    {
        double[] averageTemperatures = new double[12];

        for (int month = 0; month < 12; month++)
        {
            double sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperatures[month, day];
            }
            averageTemperatures[month] = sum / 30; // Средняя температура для месяца
        }

        return averageTemperatures;
    }
}