using System; //Utilizando o 1 PROG

class Program // Identificação do PROG
{
    static void Main() // Resposta de Acordo
    {
        // Escrever na tela
        Console.Write("Media de notas da sala - Aluno 1 " );
        
        
        // Declaração das Variaveis
        Console.Write("Digite o Primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o Segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        
           Console.Write("Digite o Terceiro número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o Quarto número: ");
        double numero4 = Convert.ToDouble(Console.ReadLine());
        
           Console.Write("Digite o Quinto número: ");
        double numero5 = Convert.ToDouble(Console.ReadLine());
        
           //Operações matematicas
        double soma1 = numero1 + numero2 + numero3 + numero4 + numero5/5;
        
     
           // Escrever na tela
        Console.Write("Media de notas da sala - Aluno 2" );
        
        // Declaração das Variaveis
        Console.Write("Digite o Primeiro número:  ");
        double numero6 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o Segundo número: ");
        double numero7 = Convert.ToDouble(Console.ReadLine());
        
           Console.Write("Digite o Terceiro número: ");
        double numero8 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o Quarto número: ");
        double numero9 = Convert.ToDouble(Console.ReadLine());
        
           Console.Write("Digite o Quinto número: ");
        double numero10 = Convert.ToDouble(Console.ReadLine());
        
        
        //Operações matematicas
        double soma2 = numero6 + numero7 + numero8 + numero9 + numero10/5;
        double media = soma1 + soma2/2;
     
        
        // Exibição
        Console.WriteLine();
        Console.WriteLine("Resultado da Media das Notas");
        Console.WriteLine("O valor da Media é: " + media);
       
    }
}