using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("MÉDIA DA SALA");
        Console.WriteLine();

        float[] notas = new float[11];
        float[] medias = new float[10];
        float soma = 0;
        float media = 0;
        bool acimaM = false;

        for (int i = 1; i < notas.Length; i++)
        {
            try
            {
            Console.Write($"Qual a nota do aluno {i}: ");
            notas[i] = float.Parse(Console.ReadLine());
            soma += notas[i];
            }catch
            {
                Console.WriteLine("Digita direito >:(");
            }
        }

        media = soma/notas.Length; //pega a quantidade do array (array.Length)
        
        Console.WriteLine($"\nTodas as notas:");
        for (int i = 1; i < notas.Length; i++)
        {
            Console.WriteLine($"-Aluno {i}-> {notas[i]}");
        }
        Console.WriteLine();
        Console.WriteLine($"A nota da sala total é {soma}");
        Console.WriteLine($"A média total da sala é {media}");
        Console.WriteLine("\nNotas acima da média:");
        Console.WriteLine();

        for (int i = 1; i < notas.Length; i++)
        {
            if(notas[i] > media)
            {
                acimaM = true;
            }

            if(acimaM == true)
            {
            Console.WriteLine($"Notas {i+1} -> {notas[i]}");
            }
        }

        if (acimaM == false)
        {
            acimaM = false;
            Console.WriteLine("Nenhuma nota acima da média");
        }

    }
}