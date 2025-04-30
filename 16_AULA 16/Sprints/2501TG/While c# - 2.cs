using System;

class Program
{
    static void Main()
    {



    // variaveis
    float soma = 0;
    float numero = -1; // valor diferente de 0 para entrar no while

        while (numero !=0)
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            try
            {
                
                numero = float.Parse(entrada);
                soma += numero;
            }

            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, digite um número válido.");
            }
        }
        Console.WriteLine($"\nA soma dos números digitados é: {soma}");
    }
}