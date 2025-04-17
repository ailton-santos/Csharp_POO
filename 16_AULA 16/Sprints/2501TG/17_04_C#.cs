using System; // Utilizando o 1 progr

class Program // identificacao do progr
{
    static void Main()
    {
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("Aluno 1. Digite as notas das suas provas: ");
        Console.Write("Digite a primeiro nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quinta nota: ");
        double nota5 = Convert.ToDouble(Console.ReadLine());

        double media1 = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

        Console.WriteLine("A media do aluno 1 é: " + media1);

        Console.WriteLine("Aluno 2. Digite as notas das suas provas: ");

        Console.Write("Digite a primeiro nota: ");
        double nota6 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota7 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota8 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        double nota9 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quinta nota: ");
        double nota10 = Convert.ToDouble(Console.ReadLine());

        double media2 = (nota6 + nota7 + nota8 + nota9 + nota10) / 5;

        Console.WriteLine("A media do aluno 2 é: " + media2);

        double media3 = (media1 + media2) / 2;

        Console.WriteLine("A media do aluno 1 e do aluno 2 é de: " + media2);


      }
}