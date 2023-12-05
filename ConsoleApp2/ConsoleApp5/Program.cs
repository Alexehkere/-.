using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            var temperature = new Dictionary<string, int[]>();
            int minTemp = -30;
            int maxTemp = 20;
            Random random = new Random();
            string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };
            foreach (string month in months)
            {
                int[] temp = new int [30];
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = random.Next(minTemp, maxTemp);
                }

                temperature.Add(month, temp);
            }

            var avgTemperature = new Dictionary<string, int>();
            foreach (string month in months)
            {
                int average = 0;
                foreach (var VARIABLE in temperature.GetValueOrDefault(month))
                {
                    average = average + VARIABLE;
                }

                average = average / 30;
                avgTemperature.Add(month, average);
            }

            int aY = 0;
            Console.WriteLine();
            foreach (var month in months)
            {
                Console.WriteLine($"{month} {avgTemperature.GetValueOrDefault(month)}");
                aY = aY + avgTemperature.GetValueOrDefault(month);
            }

            Console.WriteLine(aY / 12);
        }

    }
}