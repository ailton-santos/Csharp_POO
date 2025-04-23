using System;

class Program
{
    static void Main() {
        Console.Write("CALCULADORA DE MÉDIA\n\n");
        
        Console.Write("ALUNO 1\n");
        Console.Write("Digite Nota 1: ");
        double a1n1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 2: ");
        double a1n2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 3: ");
        double a1n3 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 4: ");
        double a1n4 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 5: ");
        double a1n5 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("\n\nALUNO 2\n");
        Console.Write("Digite Nota 1: ");
        double a2n1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 2: ");
        double a2n2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 3: ");
        double a2n3 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 4: ");
        double a2n4 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite Nota 5: ");
        double a2n5 = Convert.ToDouble(Console.ReadLine());
        
        double media1 = (a1n1+a1n2+a1n3+a1n4+a1n5)/5;
        double media2 = (a2n1+a2n2+a2n3+a2n4+a2n5)/5;
        
        Console.Write("\nMédia Aluno 1 = " + media1);
        Console.Write("\nMédia Aluno 2 = " + media2);
        Console.Write("\nMédia da Sala = " + ((media1+media2)/2));

        
    }
}