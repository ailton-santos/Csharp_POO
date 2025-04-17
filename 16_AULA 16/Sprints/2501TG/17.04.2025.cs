using System; // Utilizando o 1 programa

class Program // Identificação do programa
{
    static void Main() // Resposta de Acordo com oq estiver dentro.
    {
        // Printa no cmd
        Console.Write("Calculadora De médias"); 
        
        // Notas aluno1
        Console.Write("Digite a primeira do primeiro aluno ");
        double nota1aluno1 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a segunda do primeiro aluno ");
        double nota2aluno1 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a terceira do primeiro aluno ");
        double nota3aluno1 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a quarta do primeiro aluno ");
        double nota4aluno1 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a quinta do primeiro aluno ");
        double nota5aluno1 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        // Notas aluno2
        Console.Write("Digite a primeira do segundo aluno ");
        double nota1aluno2 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a segunda do segundo aluno ");
        double nota2aluno2 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a terceira do segundo aluno ");
        double nota3aluno2 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a quarta do segundo aluno ");
        double nota4aluno2 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        Console.Write("Digite a quinta do segundo aluno ");
        double nota5aluno2 = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine (lê oq a pessoa colocar, deve ter () que será o digito)
        
        
        // Operações Matemáticas
        double mais1 = nota1aluno1 + nota2aluno1 + nota3aluno1 + nota4aluno1 + nota5aluno1;
        double resultado1 = mais1 / 5;
        double mais2 = nota1aluno2 + nota2aluno2 + nota3aluno2 + nota4aluno2 + nota5aluno2;
        double resultado2 = mais2 / 5;
        
        
        
        // Exibição
        Console.WriteLine();
        Console.WriteLine("Resultado das Operações:");
        // Resultados - o + também é usado pra concatenar ou seja juntar coisas exemplo
        Console.WriteLine("Notas:");
        Console.WriteLine("A média do 1° aluno é " + resultado1);
        Console.WriteLine("A média do 2° aluno é " + resultado2);
        
        
    }
}