using System;

class Program
{
    public static float valorTotal = 0;
    public static float valorProduto = -1; // para entrar no while, o numero tem que ser diferente de zero
    static void Main()
    {
        Console.WriteLine("Digite o valor de cada produto. Para encerrar, digite 0.");
        try
        {
            
        while (valorProduto != 0)
        {
            Console.Write("Digite o valor de cada produto: ");
            valorProduto = float.Parse(Console.ReadLine());
            valorTotal += valorProduto;
        }
        }
        catch
        {
            Console.WriteLine("Digite o valor dos produtos corretamente.");
            Main();
        }

        Console.WriteLine("\nO valor total da compra eh: " + valorTotal);
    }
}