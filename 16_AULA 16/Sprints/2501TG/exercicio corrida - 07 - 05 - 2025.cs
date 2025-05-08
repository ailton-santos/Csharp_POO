using System;
using System.Threading;

class Corrida
{
    static void Main()
    {
        int larguraPista = 40;
        char[] pista = new char[larguraPista];

        for (int i = 0; i < larguraPista; i++)
        {
            pista[i] = ' ';
        }

        int posicaoCorredor1 = 0;
        int posicaoCorredor2 = 0;

        Random random = new Random();

        Console.WriteLine("Bem-vindo a corrida de caracteres!");
        Console.WriteLine("Pressione qualquer tecla para iniciar...");
        Console.ReadKey();
        while (true)
        {
            posicaoCorredor1 += random.Next(1, 4);
            posicaoCorredor2 += random.Next(1, 4);

            if (posicaoCorredor1 >= larguraPista - 1)
            {
                Console.WriteLine("Corredor 1 venceu!");
                break;
            }
            else if (posicaoCorredor2 >= larguraPista - 1)
            {
                Console.WriteLine("Corredor 2 venceu!");
                break;
            }
            else if (posicaoCorredor1 >= larguraPista && posicaoCorredor2 >= larguraPista)
            {
                Console.WriteLine("Empate!");
                break;
            }
            
            for (int i = 0; i < larguraPista; i++)
            {
                if (i == posicaoCorredor1 && i == posicaoCorredor2)
                {
                    pista[i] = '%';
                }
                else if (i == posicaoCorredor1)
                {
                    pista[i] = '1';
                }
                else if (i == posicaoCorredor2)
                {
                    pista[i] = '2';
                }
                else if (i == larguraPista - 1)
                {
                    pista[i] = '|'; 
                }
                else
                {
                    pista[i] = '.';
                }
            }

            Console.Write("\n" + new string(pista)); 
            Console.WriteLine(); 

            Thread.Sleep(500);
        }
    }
}





