Random random = new Random();
        
int[] nums = new int[10];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = random.Next(1, 1000);
}

int minIndex = 0;
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] < nums[minIndex])
    {
        minIndex = i;
    }
}

Console.WriteLine($"Номер минимального элемента: {minIndex}");







