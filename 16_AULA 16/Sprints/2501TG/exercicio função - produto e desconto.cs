class Program
{
    static void Main()
    {

        while (true)
        {
            Console.Write("Digite o nome do produto: ");
            string produto = Console.ReadLine();
            if (produto.ToLower() == "sair")
            {
                break;
            }
            Console.Write($"Digite o preço de {produto}: ");
            string precoStr = Console.ReadLine();
            float preco;
            if (!float.TryParse(precoStr, out preco))
            {
                Console.WriteLine("Preço inválido. Por favor, digite um número.");
                continue;
            }
            if (produto.ToLower() == "sair")
            {
                break;
            }

            Console.Write($"Digite em % o desconto de {produto} (preço original: R${preco} ): ");
            string descontoStr = Console.ReadLine();
            float desconto;
            if (!float.TryParse(descontoStr, out desconto))
            {
                Console.WriteLine("Desconto inválido. Por favor, digite um número.");
                continue;
            }

            if (desconto < 0 || desconto > 100)
            {
                Console.WriteLine("Desconto inválido. Por favor, digite um valor entre 0 e 100.");
                continue;
            }
            if (produto.ToLower() == "sair")
            {
                break;
            }
            Exibirdesconto (preco, desconto);
        }
    

    static float CalcularDesconto(float preco, float desconto)
    {
        return preco - (preco * (desconto / 100));
    }

    static void Exibirdesconto(float preco, float desconto)
    {
        float precoComDesconto = CalcularDesconto(preco, desconto);
        Console.WriteLine($"Preço original: {preco} \nDesconto: {desconto}% \nPreço com desconto: {precoComDesconto}");
    }
}

}