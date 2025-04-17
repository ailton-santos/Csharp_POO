using System;

class Program
{
    static void Main() {
        Console.WriteLine();
        Console.WriteLine("Média da nota total da sala:");
        Console.WriteLine();
        
        Console.WriteLine("Fulano:");
        Console.Write("Digite a nota 1 do Primeiro aluno-> ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 2 do Primeiro aluno-> ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 3 do Primeiro aluno-> ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 4 do Primeiro aluno-> ");
        double num4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 5 do Primeiro aluno-> ");
        double num5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Fulana:");
        Console.Write("Digite a nota 1 do Segundo aluno-> ");
        double num6 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 2 do Segundo aluno-> ");
        double num7 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 3 do Segundo aluno-> ");
        double num8 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 4 do Segundo aluno-> ");
        double num9 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota 5 do Segundo aluno-> ");
        double num10 = Convert.ToDouble(Console.ReadLine());
        
        //vars do aluno 1 e 2
        double fulo = num1 + num2 + num3 + num4 + num5;
        double fula = num6 + num7 + num8 + num9 + num10;
        
        //Contas
        double mediaT = fulo + fula;
        double mediaR = mediaT / 10;
        
        //Mostrando a média calculada
        Console.WriteLine();
        Console.WriteLine("A média da sala com fulano e fulana é de: " + mediaR);
        Console.WriteLine();
        
        
        
        
    }
}