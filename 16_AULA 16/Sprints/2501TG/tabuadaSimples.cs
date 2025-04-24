using System;

public class Program
{
    public static void Main()
    {
       Console.WriteLine("Tabuada simples");
       Console.WriteLine("Digite um número");
       string entrada = Console.ReadLine();
       int numero = 0;
       // verificar se o valor digitado é um numero inteiro
       if (int.TryParse(entrada, out numero))
       {
           Console.WriteLine($"\n Tabuada do {numero}: ");
           for (int i = 1; i <= 10; i++)
           {
               int resultado = numero * i;
               Console.WriteLine($"{numero} x {i} = {resultado}");
           }
       }
       else
       {
           Console.WriteLine("Erro: Digite um número inteiro válido.");
           Main();
       }
       Console.ReadLine();
    }
}