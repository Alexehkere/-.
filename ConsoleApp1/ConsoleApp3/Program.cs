
        List<string> array = new List<string>();
        string input;
        do
        {
            Console.WriteLine("Введите число (введите 0 для завершения): ");
            input = Console.ReadLine();
            if (input != "0")
            {
                array.Add(input);
            }
        } while (input != "0");
            

        int minStr = 0;
        int maxStr = 0;
        for (int i = 1; i < array.Count; i++)
        {
            if (array[i].Length < array[minStr].Length)
            {
                minStr = i;
            }
            
            if (array[i].Length > array[maxStr].Length)
            {
                maxStr = i;
            }
        }

        Console.WriteLine($"Самый короткий элемент списка: {array[minStr]}");
        Console.WriteLine($"Самый длинный элемент списка: {array[maxStr]}");
