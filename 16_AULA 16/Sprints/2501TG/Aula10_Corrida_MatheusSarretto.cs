using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int largura = 40;
        string[] tela = new string[largura];
        
        for (int i = 0; i < largura; i++){
            tela[i] = " ";
            if (i == 39){
                tela[i] = "🏁";
            }
        }
        
        int carX = 0;
        int carY = 1;
        
        int x = 0;
        int y = 0;

        for (; carX < largura - 3 && carY < largura - 2; x = rand.Next(1, 4), y = rand.Next(1, 4))
        {
            tela[carX] = " ";
            tela[carY] = " ";
            
            carX = carX + x;
            carY = carY + y;
            
            if (carX == carY) {
                x = rand.Next(1, 3);
                if (x == 1) {
                    carX--;
                }
                else {
                    carY--;
                }
            }
            
            if (carX >= 39 || carY >= 39) {
                if (carX > carY){
                    carX = 38;
                    if (carY >= 39){
                        carY = 37;
                    }
                }
                else if (carY > carX){
                    carY = 38;
                    if (carX >+ 39){
                        carX = 37;
                    }
                }
            }
            
            tela[carX] = "🚗";
            tela[carY] = "🚕";
            
            Console.WriteLine(string.Join("", tela));

            Thread.Sleep(200);
        }
        
        if (carX > carY){
            Console.WriteLine("\nCarro vermelho venceu! 🏆🟥 ");
        }
        else {
            Console.WriteLine("\nCarro amarelo venceu! 🏆🟨");
        }
    }
}
