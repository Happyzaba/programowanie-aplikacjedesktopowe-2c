internal class Program
{
    static Random random = new Random();

    private static void Main(string[] args)
    {
        Console.Write("Ile zestawów wylosować? ");
        int zestawy = int.Parse(Console.ReadLine());

        int[,] wyniki = new int[zestawy, 6];
        int[] wystapienia = new int[50];

        for (int i = 0; i < zestawy; i++)
        {
            HashSet<int> zbior = new HashSet<int>();
            while (zbior.Count < 6)
            {
                int liczba = random.Next(1, 50);
                zbior.Add(liczba);
            }

            int j = 0;
            foreach (int liczba in zbior)
            {
                wyniki[i, j++] = liczba;
                wystapienia[liczba]++;
            }
        }

        for (int i = 0; i < zestawy; i++)
        {
            Console.Write("Losowanie " + (i + 1) + ": ");
            for (int j = 0; j < 6; j++)
                Console.Write(wyniki[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\nWystąpienia liczb:");
        for (int i = 1; i <= 49; i++)
        {
            if (wystapienia[i] > 0)
                Console.WriteLine($"Liczba {i}: {wystapienia[i]}");
        }
    }
}