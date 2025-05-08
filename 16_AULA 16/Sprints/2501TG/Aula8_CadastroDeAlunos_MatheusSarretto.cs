using System;

class Program
{
    static void Main() {
        string[] nomes = new string [3];
        float[] nota1 = new float [3];
        float[] nota2 = new float [3];
        float[] medias = new float [3];
        
        Console.WriteLine("Cadastro de 3 alunos");
        
        for (int i = 0; i < 3; i++){
            Console.Write($"\nDigite o nome do aluno {i+1}: ");
            nomes[i] = Console.ReadLine();
            
            Console.Write($"Digite a 1ª nota do aluno {nomes[i]}: ");
            nota1[i] = float.Parse(Console.ReadLine());
            
            Console.Write($"Digite a 2ª nota do aluno {nomes[i]}: ");
            nota2[i] = float.Parse(Console.ReadLine());
            
            medias[i] = CalcularMedia(nota1[i], nota2[i]);
            
        }
        
        Console.WriteLine("\nResultado Final:\n ");
        for(int i = 0; i < 3; i++){
            Console.WriteLine($"Aluno {nomes[i]}, nota 1: {nota1[i]}");
            Console.WriteLine($"Aluno {nomes[i]}, nota 2: {nota2[i]}");
            Console.WriteLine($"Aluno {nomes[i]}, média: {medias[i]}");
            Console.WriteLine($"Aluno {nomes[i]}: " + CalcularSituacao(medias[i]));
            Console.WriteLine();
        }
        Console.WriteLine("Média dos alunos: ", medias[1] + medias[2] + medias[3]);
        
    }
    
    static float CalcularMedia(float n1, float n2) {
    return (n1 + n2) / 2;
    }
    
    static string CalcularSituacao(float media) {
        if (media >= 6.0f)
            return "Aprovado";
        else if (media >= 4.0f)
            return "Recuperação";
        else return "Reprovado";
    }
} 