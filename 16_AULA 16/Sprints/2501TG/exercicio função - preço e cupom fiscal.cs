using System;

class Program
{
    static void Main() 
    {
        string[] nomesprodutos = new string [5];
        float[] preco = new float [5];
        float[] totalmain = new float [5];

        Console.WriteLine("[CUPOM FISCAL DE 5 PRODUTOS]\n");

        // Entrada
        for (int i = 0; i<3; i++)
        {
            Console.Write($"Digite o nome do produto {i + 1}: ");
            nomesprodutos[i] = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço de {nomesprodutos[i]}: ");
            preco[i] = float.Parse(Console.ReadLine());

            totalmain[i] = CalcularTotal(preco);
        }
        // exibir
        ExibirNotaFiscal(nomesprodutos, preco);
    }


// função para calcular total da compra
    static float CalcularTotal(float[] preco)
    {
        float total = 0;
        for (int i = 0; i<3; i++)
        {
            total += preco[i];
        }
        return total;
    }

// função para exibir nota fiscal da compra
    static void ExibirNotaFiscal(string[] np, float[] p)
    {
        Console.WriteLine("[NOTA FISCAL]");
        for (int i = 0; i<3; i++)
        {
            Console.WriteLine($"{np[i]} - R$ {p[i]}");
        }
        Console.WriteLine($"Total: R$ {CalcularTotal(p)}");
    }
}