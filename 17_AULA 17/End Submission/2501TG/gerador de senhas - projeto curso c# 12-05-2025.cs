using System;

class Program
{
    static void Main()
    {
        string[] opcoes = ObterOpcoes();
        int comprimento = ObterComprimento();
        EnviarOpcoes(opcoes);
        int qtdopcoes = ObterQuantidadeOpcoes();
        int[] opcoesEscolhidas = ObterOpcoesEscolhidas(opcoes, qtdopcoes);
        string senha = GerarSenha(opcoesEscolhidas, comprimento);
        Console.WriteLine($"Senha gerada: {senha}");
    }

    static string[] ObterOpcoes()
    {
        return new string[] { "Maiúsculas", "Minúsculas", "Números", "Especiais" };
    }

    static void EnviarOpcoes(string[] opcoes)
    {
        Console.WriteLine("Em nosso programa podemos gerar senhas com as seguintes opções:");
        for (int i = 0; i < opcoes.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {opcoes[i]}");
        }
    }

    static int ObterComprimento()
    {
        Console.Write("Digite o comprimento da senha: ");
        return int.Parse(Console.ReadLine());
    }

    static int ObterQuantidadeOpcoes()
    {
        Console.Write("Quantas opções deseja escolher? ");
        return int.Parse(Console.ReadLine());
    }

    static int[] ObterOpcoesEscolhidas(string[] opcoes, int qtdopcoes)
    {
        Console.WriteLine("Escolha as opções de complexidade:");
        for (int i = 0; i < opcoes.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {opcoes[i]}");
        }
        int[] opcoesEscolhidas = new int[qtdopcoes];
        for (int i = 0; i < opcoesEscolhidas.Length; i++)
        {
            Console.Write($"Escolha a opção {i + 1}: ");
            opcoesEscolhidas[i] = int.Parse(Console.ReadLine());
        }
        return opcoesEscolhidas;
    }

    static string GerarSenha(int[] opcoesEscolhidas, int comprimento)
    {
        string caracteres = "";
        for (int i = 0; i < opcoesEscolhidas.Length; i++)
        {
            if (opcoesEscolhidas[i] == 1)
            {
                caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (opcoesEscolhidas[i] == 2)
            {
                caracteres += "abcdefghijklmnopqrstuvwxyz";
            }
            else if (opcoesEscolhidas[i] == 3)
            {
                caracteres += "0123456789";
            }
            else if (opcoesEscolhidas[i] == 4)
            {
                caracteres += "!@#$%&*";
            }
        }
        Random random = new Random();
        string senha = "";
        for (int i = 0; i < comprimento; i++)
        {
            senha += caracteres[random.Next(caracteres.Length)];
        }
        return senha;
    }
}


