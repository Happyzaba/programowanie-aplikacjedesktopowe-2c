internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Ile wygerenować losowań?");
        int losowania = int.Parse(Console.ReadLine());
        Console.WriteLine("Zestawy wylosowanych liczb");

        for (int i = 1; i <= losowania; i++) {
            Console.WriteLine("Losowanie: " + i);
            

        }
    }
}