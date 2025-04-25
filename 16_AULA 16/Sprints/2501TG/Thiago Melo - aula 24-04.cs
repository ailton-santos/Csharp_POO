using System;

class Program
{
    static void Main()
    {
        /*Console.WriteLine("Números de 1 a 20.");

        //o "for" serve pra fazer meio que uma tabela
        //existe dois, 'for' e 'io'
        
        for (int i = 1; i <= 20; i++) //"i" representa a primeira interação, o início (se colocar 4 vai do 4 até o 20 ao invés de 1 a 20)
        {
            //verifica se é par -> verificar operadores lógicos
            if(i % 2 == 0) //% -> resto da divisão, confirmando se o número divido por 2 e que sobre 0
            {
                
            }
        }
        //for (int i = 1(INICIAL); (FINAL); (INCREMENTO);)*/
        

       /* Console.WriteLine("Tabuada Simples");
        Console.Write("Digite um número INTEIRO para ver a sua tabuada -> ");
        
        string entra = Console.ReadLine();
        int numer;

        //verifica se o que for digitado é um número inteiro
        if(int.TryParse(entra, out numer)) //TryParse é uma versão do "try catch", funciona da mesma forma, um abreviação
        {
            Console.WriteLine($"\nTabuada do {numer}");//"\n" serve pra pular a linha ao invés de ter que escrever outro Console.WriteLine, "$" serve pra colocar uma variavel DENTRO da aspas (string)

            for (int i=0; i<=10; i++)
            {
                int resultado = numer * i;
                Console.WriteLine($"{numer} . {i} = {resultado}");
            }
        }else //catch
        {
            Console.WriteLine("ERRO: Digite um número inteiro válido.");
        }*/


        /*Console.WriteLine("Todos os número multiplos de 3 entre 1 - 50.");
        for (int i=0; i<=50; i++)
        {
            if (i % 3 == 0)//para ver se um númeor é MULTIPLO, temque sobrar 0
            {
                Console.WriteLine(i);
            } else
            {
                //não mostrar o resto :3
            }
        } */


        Console.WriteLine("Calcular a Média dos alunos V2");
        Console.WriteLine();

        Console.Write("Quantas notas você quer de cada aluno:");
        double nota = Convert.ToDouble(Console.ReadLine());


        if(nota > 10)
        {
            Console.WriteLine("ERRO: OVERLOAD.");
        }else
        {
      try
      {
        if (nota < 2)
        {
            Console.Write("Não pode ter menos que 2 notas!");
        }else 
    {
        if (nota == 10)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quinta nota:");
            double not5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sexta nota:");
            double not6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sétima nota:");
            double not7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a oitava nota:");
            double not8 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a nona nota:");
            double not9 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a décima nota:");
            double not10 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2 + not3 + not4 + not5 + not6 + not7 + not8 + not9 + not10
            double mediaR = mediaT / 10;

            Console.WriteLine($"A média total das 10 notas são -> {mediaR}")
        }else if (nota == 9)
        {
           Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quinta nota:");
            double not5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sexta nota:");
            double not6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sétima nota:");
            double not7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a oitava nota:");
            double not8 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a nona nota:");
            double not9 = Convert.ToDouble(Console.ReadLine());
            
            double mediaT = not1 + not2 + not3 + not4 + not5 + not6 + not7 + not8 + not9
            double mediaR = mediaT / 9;

            Console.WriteLine($"A média total das 10 notas são -> {mediaR}")
        }else if (nota == 8)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quinta nota:");
            double not5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sexta nota:");
            double not6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sétima nota:");
            double not7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a oitava nota:");
            double not8 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2 + not3 + not4 + not5 + not6 + not7 + not8
            double mediaR = mediaT / 8;

            Console.WriteLine($"A média total das 8 notas são -> {mediaR}")
        }else if (nota == 7)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quinta nota:");
            double not5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sexta nota:");
            double not6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sétima nota:");
            double not7 = Convert.ToDouble(Console.ReadLine());    

            double mediaT = not1 + not2 + not3 + not4 + not5 + not6 + not7
            double mediaR = mediaT / 7;

            Console.WriteLine($"A média total das 7 notas são -> {mediaR}")  
        }else if (nota == 6)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quinta nota:");
            double not5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a sexta nota:");
            double not6 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2 + not3 + not4 + not5 + not6
            double mediaR = mediaT / 6;

            Console.WriteLine($"A média total das 6 notas são -> {mediaR}")
        }else if (nota == 5)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quinta nota:");
            double not5 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2 + not3 + not4 + not5
            double mediaR = mediaT / 5;

            Console.WriteLine($"A média total das 5 notas são -> {mediaR}")
        }else if (nota == 4)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a quarta nota:");
            double not4 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2 + not3 + not4
            double mediaR = mediaT / 4;

            Console.WriteLine($"A média total das 4 notas são -> {mediaR}")
        }else if (nota == 3)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a terceira nota:");
            double not3 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2 + not3
            double mediaR = mediaT / 3;  

            Console.WriteLine($"A média total das 3 notas são -> {mediaR}")
        }else if (nota == 2)
        {
            Console.Write("Qual foi a primeira nota:");
            double not1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual foi a segunda nota:");
            double not2 = Convert.ToDouble(Console.ReadLine());

            double mediaT = not1 + not2
            double mediaR = mediaT / 2;

            Console.WriteLine($"A média total das 2 notas são -> {mediaR}")
        }





    }
      }catch
      {
            Console.WriteLine("ERRO: Digite um número valido.");
      }
        }





        
         Console.ReadLine(); //check extra, não é 100% necessário
    }
}