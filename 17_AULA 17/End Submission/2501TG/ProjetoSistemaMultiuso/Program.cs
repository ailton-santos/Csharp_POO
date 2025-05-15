/*Esse código provavelmente tem VARIOS bugs, e eu não vou arrumar nenhum deles :3
        -Tigrão
*/

using System;
using System.Threading;


class Program
{
    static void Main()
    {
        Thread.Sleep(3000);
        Console.WriteLine("Iniciando sistema");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(2000); //uma cutscene, nada de mais importante.
        Console.WriteLine("Sistema atualizado! O que gostaria de fazer?");
        Thread.Sleep(500);
        menu();
    }

    public static string menu() //menu principal
    {
        Console.WriteLine("[0] Sair");
        Console.WriteLine("[1] Cadastro de nomes");
        Console.WriteLine("[2] Caixa de mercado");
        Console.WriteLine("[3] Calcular a Média de três alunos");
        Console.WriteLine("[4] Minigame aleatório"); //colocar mais de um minigame no futuro
        Console.Write("Digite aqui -> ");
        string entry = Console.ReadLine().ToLower();

        switch (entry)
        {
            case "0":
                Console.Write("Saindo do sistema");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                break;
            case "1":
            Console.WriteLine("Iniciando cadastro");
                Thread.Sleep(1400);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                cadastro();
                return menu();
                break;

            case "2":
            Console.WriteLine("Ligando caixa do mercado");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1500);
                Console.Write(".");
                Thread.Sleep(3000);
                Console.Write(".");
                mercado();
                return menu();
                break;

            case "3":
            Console.WriteLine("Calculando a média");
                Thread.Sleep(1400);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                escolaMedia();
                return menu();
                break;

            case "4":
            Console.WriteLine("Escolhendo minigame");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(1500);
                Console.Write(".");
                adivinhacao();
                return menu();
                break;

            default:
                Console.WriteLine("ERRO >A<");
                return menu();
                break;
        }
        return ""; //return vazio para que a função funcione
        //não pode ter no começo ou quebra o código, C# é retardado na real :/
    }
    
    //funções 1 - 4

    //função 1
    static void cadastro()
    {
        string[] nomes = new string[10];
        bool entry = false;
        char userIP = 'a';

        Console.WriteLine();
        Console.WriteLine("Cadastro de nomes");
        Console.WriteLine();

        login(nomes);

        Console.WriteLine();
        try
        {
            Console.WriteLine("Nomes cadastrados com sucesso! Gostaria de pesquisar um nome?");
            Console.Write("Y / N → ");
            userIP = Convert.ToChar(Console.ReadLine().ToUpper());
        }
        catch
        {
            Console.WriteLine("Digita direito >:(");
        }

        if (userIP == 'Y')
        {
            entry = true;
        }
        else
        {
            entry = false;
        }

        while (entry)
        {
            Console.WriteLine("Pesquisa de nomes");
            search("", nomes); /*nem sempre precissa ser colocado um variavel exata para a função
        string por exemplo, sendo uma entrada do usuario pode ser em branco já que a função faz o trabalho*/
        }

        if (entry = false)
        {
            Console.WriteLine("Fim do programa.");
        }
        else
        {
            Console.WriteLine("Cadastro concluído.");
        }
    }

    static void login(string[] NO)
    {
        for (int i = 0; i < NO.Length; i++)
        {
            Console.Write($"Por favor digite o {i + 1}º nome: ");
            NO[i] = Console.ReadLine();

            Console.WriteLine("\nNome cadastrado!");
        }
    }
    static void search(string user, string[] array)
    {
        Console.Write("Digite um nome: ");
        user = Console.ReadLine();

        if (array.Contains(user.ToLower())) //compara o que o usuario digitou se faz parte do array
        {
            Console.WriteLine($"Nome encontrado :D");
        }
        else
        {
            Console.WriteLine("Nome não encontrado D:");
        }
    }



    //função 2
    static void mercado()
    {
        Console.WriteLine();
        Console.WriteLine("Caixa do mercado Super Mario. Digite '0' para confirmar a compra");
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



    //função 3
        static void escolaMedia()
    {
        Console.WriteLine();
        Console.WriteLine("Cadastro de alunos");
        Console.WriteLine();

        string[] nomes = new string[3];
        float[] nota1 = new float[3];
        float[] nota2 = new float[3];
        float[] medias = new float[3];

        Console.WriteLine("\nPor favor, cadastre 3 alunos:");
        Console.WriteLine();

        for(int i=0; i<3; i++)
        {
        Console.Write($"Digite o nome do aluno {i + 1}: ");
        nomes[i] = Console.ReadLine();
        Console.Write($"Digite a 1ª nota do aluno {nomes[i]}: ");
        nota1[i] = float.Parse(Console.ReadLine());
        Console.Write($"Digite a 2ª nota do aluno {nomes[i]}: ");
        nota2[i] = float.Parse(Console.ReadLine());
        

        medias[i] = calcularMedia(nota1[i], nota2[i]);
        Console.WriteLine();
        }
        
        Console.WriteLine("\nResultado final:");
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Aluno {nomes[i]} tem a nota {nota1[i]} e {nota2[i]}.");
            Console.WriteLine($"Aluno {nomes[i]} foi {verificarSituacao(medias[i])}.");
        }
    }
    
    
//criação de função, ao invés de ser uma biblioteca é um unico livro (se fazer sentido)
//função tem que estar dentro da classe para funcionar, sendo o objeto C# é orientado por objetos

static float calcularMedia(float n1, float n2) //parametros
{
    return(n1 + n2) / 2; //retorna o desejado, sendo a váriavel calcularMedia. Direto para o static void (principal)
}

static string verificarSituacao(float media) /*static é a mesma coisa que função, string sendo o mais comum
"void" é considerado o principal por isso não é static void para função*/
{
    if(media <= 6.0f && media >= 6.0f) //em caso if especificar o valor EXATO é bom dependendo da situação
        return "Aprovado"; //sendo uma função baseada em string não precisa do console.writeline
        
        else if(media <= 4.0f && media >= 4.0f)
            return "Recuperação";
            
            else
                return "Reprovado";
}

    

    //função 4
    static void adivinhacao()
    {
        int vida = 3;
        Random random = new Random();
        int lucky = random.Next(1, 101);

        Console.WriteLine();
        Console.WriteLine("Estou pensando em um número de 1 a 100, consegue adivinhar em 3 tentativas?");
        Console.WriteLine();

        Console.WriteLine($"Tentativas: {vida}");
        Console.Write("Resposta: ");
        string entry = Console.ReadLine();

        try
        {
            while (entry != null && vida > 0)
            {
                if (int.Parse(entry) != lucky)
                {
                    vida--;
                    Console.WriteLine("Errou! Tente novamente!");
                    Console.WriteLine($"Tentativas: {vida}");
                    Console.Write("Resposta: ");
                    entry = Console.ReadLine();
                    if (vida == 0)
                    {
                        Console.WriteLine("Errou! As suas vidas acabaram D:");
                    }
                }
                else
                {
                    Console.WriteLine("Errou! As suas vidas acabaram D:");
                }
            }
        }
        catch
        {
            Console.WriteLine("ERRO: Digite um valor valido");
        }

        if (int.Parse(entry) == lucky)
        {
            Console.WriteLine("Parabens! Você acertou!");

        }
        else if (vida <= 0)
        {
            Console.WriteLine("Errou! As suas vidas acabaram D:");
        }
    }
}