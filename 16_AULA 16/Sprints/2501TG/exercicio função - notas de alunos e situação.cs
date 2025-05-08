using System;

class Program
{
    static void Main() 
    {
        string[] nomes = new string [3];
        float[] nota1 = new float [3];
        float[] nota2 = new float [3];
        float[] nota3 = new float [3];
        float[] medias = new float [3];

        Console.WriteLine("[CADASTRO DE 3 ALUNOS]\n");

        // Entrada
        for (int i = 0; i<3; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine();
            
            Console.WriteLine($"Digite a primeira nota do aluno {nomes[i]}: ");
            nota1[i] = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a segunda nota do aluno {nomes[i]}: ");
            nota2[i] = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a terceira nota do aluno {nomes[i]}: ");
            nota3[i] = float.Parse(Console.ReadLine());

            medias[i] = Calcularmedia(nota1[i], nota2[i], nota3[i]);
            Console.WriteLine();
        }
        // Exibir
        for (int i = 0; i<3; i++)
        {
            Console.WriteLine($"Aluno {nomes[i]}");
            Console.WriteLine($"Média {medias[i]}");
            Console.WriteLine($"Situação: {VerificarSituacao(medias[i])}\n");
        }
    }


    static float Calcularmedia(float n1, float n2, float n3)
    {
        return (n1 + n2 + n3) / 3;
    }
    
    static string VerificarSituacao(float media)
    {
        if (media >= 6.0f)
        {
            return "Aprovado";
        }
        else if (media > 4 &&  )
        {
            return "Em recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}



