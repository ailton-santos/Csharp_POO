using System;

class Program
{
    static void Main()
    {
        float soma = 0;
        float numero = -1; // valor diferente de 0 para entrar no while
    Console.WriteLine("Digite numeros para somar. digite 0 para encerrar");
    
    while (numero !=0)
    {
        Console.Write("Digite um número: ");
        numero = float.Parse(Console.ReadLine());

        soma = soma + numero;
    }
    Console.WriteLine($"\nA soma total é: {soma}");
    Console.WriteLine("Fim do Programa.");
    }
}