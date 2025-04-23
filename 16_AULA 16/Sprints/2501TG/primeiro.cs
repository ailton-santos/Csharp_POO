 using System; // Utilizando o 1 progr
  
 class Program // identificacao do progr
   {
      static void Main()
      {
          Console.WriteLine("Calculadora Básica"); 
          
          Console.Write("Digite o primeiro numero: ");
          double numero1 = Convert.ToDouble(Console.ReadLine());
          
          Console.Write("Digite o segundo numero: ");
          double numero2 = Convert.ToDouble(Console.ReadLine());
          
          // operacoes matemáticas
          double soma = numero1 + numero2;
          double subtracao = numero1 - numero2;
          double multiplicacao = numero1 * numero2;
          double divisao = numero1 / numero2;
          
          // exibicao
          
          Console.WriteLine();
          Console.WriteLine("Resultado das operações: ");
          Console.WriteLine("O valor da soma é: " + soma);
          Console.WriteLine("O valor da subtração é: " + subtracao);
          Console.WriteLine("O valor da divisão é: " + divisao);
          Console.WriteLine("O valor da multiplicação é: " + multiplicacao);
          
      }
   }