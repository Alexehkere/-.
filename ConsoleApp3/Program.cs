public class Program
{
    public static void Main()
    {
    string path = @"C:\Users\public.COPP\Desktop\laba3.txt";
        using (StreamReader stream = new StreamReader(path))
    {
        string s = stream.ReadLine();
        string[] array = s.Split(" ");
        int resultVolume = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int perevorot = Convert.ToInt32(array[i]);
            int min = perevorot = Convert.ToInt32(array[i]);
            int volum = 0;
            for (int j = 0; j < i; j++)
            {
                int perevorot2 = Convert.ToInt32(array[j]);
                if (perevorot < perevorot2)
                {
                    min = perevorot;
                }
                else
                {
                    min = perevorot2;
                }
                
                volum = min * (i - j);
                if (volum > resultVolume)
                {
                    resultVolume = volum;
                }
            }
        }

        Console.WriteLine(resultVolume);
    }
}
}