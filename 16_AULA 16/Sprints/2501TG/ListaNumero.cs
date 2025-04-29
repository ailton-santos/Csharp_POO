using System;

class Program
{
    public static float numero = -1; // para entrar no while, o numero tem que ser diferente de zero
    public static float soma = 0;
    static void Main()
    {
        
        Console.WriteLine("Digite os numeros para somar. Para encerrar, digite 0. ");
        try
        {
            while (numero != 0)
            {
                Console.Write("Digite um numero: ");
                numero = float.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine("\nA soma dos numeros digitados eh: " + soma);
            Console.WriteLine("\nFim do Programa");
        }
        catch
        {
            Console.WriteLine("Digite apenas numeros.");
            Main();
        }
    }
}
        