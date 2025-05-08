class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite um número inteiro positivo (ou 0 para sair): ");
            int numero;
            if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("Número inválido. Use apenas números inteiros positivos.");
                continue;
            }
            if (numero == 0) break;
            Console.WriteLine($"{numero} {EhPrimo(numero)}");
        }
    }
    static string EhPrimo(int num)
    {
        if (num <= 1) return "não é primo";
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0) return "não é primo";
        }
     return "é primo";
    }
}






