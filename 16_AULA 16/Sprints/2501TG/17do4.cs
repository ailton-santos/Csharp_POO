using System;

class Class
{
    static void Main() {
        Console.Write("Digite a primeira nota do aluno 1: ");
        float m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a segunda nota do aluno 1: ");
        float m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a terceira nota do aluno 1: ");
        float m3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quarta nota do aluno 1: ");
        float m4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quinta nota do aluno 1: ");
        float m5 = Convert.ToInt32(Console.ReadLine());
        
        float sum = m1 + m2 + m3 + m4 + m5;
        float media1 = sum /5;
        
        Console.Write("Média aluno1: " + media1);
        Console.WriteLine();
        
        Console.Write("Digite a primeira nota do aluno 2: ");
        float m11 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a segunda nota do aluno 2: ");
        float m22 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a terceira nota do aluno 2: ");
        float m33 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quarta nota do aluno 2: ");
        float m44 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quinta nota do aluno 2: ");
        float m55 = Convert.ToInt32(Console.ReadLine());
        
        float sum2 = m11 + m22 + m33 + m44 + m55;
        float media2 = sum2 /5;
        
        Console.Write("Média aluno2: " + media2);
        Console.WriteLine();
        
        float mediaGeral = (media1 + media2) / 2;
        
        Console.Write("Média geral: " + media2);
        
    }
    
}