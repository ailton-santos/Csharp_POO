using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Multiplos de 3 entre 1 e 50: ");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine($"Esse número é multiplo de 3: {i}");
            }
            else
            {
                Console.WriteLine($"Esse número nao é multiplo de 3: {i}");
            }
        }
        Console.ReadLine();
    }
}