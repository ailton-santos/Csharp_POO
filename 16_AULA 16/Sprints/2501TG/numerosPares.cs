using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Números pares entre 1 e 20:");
        for (int i = 1; i <= 20; i ++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Esse número é par " + i);
            }
            else 
            {
                Console.WriteLine("Esse número é impar " + i);
            }
        }
        Console.ReadLine();
    }
}