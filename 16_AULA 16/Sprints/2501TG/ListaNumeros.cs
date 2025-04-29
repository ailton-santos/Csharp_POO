using System;

class Program
{
    static void Main()
    {
        float soma = 0;
        float numero = -1; // para entrar no while, o numero tem que ser diferente de zero
        Console.WriteLine("Digite os numeros para somar. Para encerrar, digite 0. ");

        while (numero != 0)
        {
            Console.Write("Digite um numero: ");
            numero = float.Parse(Console.ReadLine());
            soma += numero;
        }

        Console.WriteLine("\nA soma dos numeros digitados eh: " + soma);
        Console.WriteLine("\nFim do Programa");
    }
}