using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Caixa do mercado Genésio. Digite '0' para confirmar a compra");
        Console.WriteLine();

        float soma = 0;
        float precoT = 1;
        float ValorBase = -1; //valor inicial para que o while funcione

        //list pode ser aplicada em qualquer coisa, string, int, boolean, etc.
        List<float> precos = new List<float>();

        while (precoT != 0)
        {
            Console.Write("Digite o preço do produto: ");
            float precoTotal = float.Parse(Console.ReadLine());

            precoT = precoTotal;

            try
            {
                soma += ValorBase;
                if (precoT != 0)
                {
                    precos.Add(soma);
                }
            }
            catch
            {
                Console.WriteLine("ERRO: Digite um valor valido");
            }
        }
        Console.WriteLine($"Soma total dos preços: R${soma}");
        Console.WriteLine("\nPreço de cada produto separado:");
        foreach (float precoTotal in precos)
        {
            Console.WriteLine("- R$" + 0);
        }
    }
}


/*como escrever uma lista:
 * class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        string nome = "";

        Console.WriteLine("Digite nomes. Para encerrar, digite 'sair'.");

        while (nome.ToLower() != "sair")
        {
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();

            if (nome.ToLower() != "sair")
            {
                nomes.Add(nome);
            }
        }

        Console.WriteLine("\nNomes cadastrados:");
        foreach (string n in nomes)
        {
            Console.WriteLine("- " + n);
        }

        Console.WriteLine("\nFim do programa.");
    }
}*/
