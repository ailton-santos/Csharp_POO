using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cadastro de alunos");
        Console.WriteLine();
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
}
