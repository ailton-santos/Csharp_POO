using System;
using System.Collections.Generic;
using System.Linq;
class Forca
{
    static List<string> palavrasFaceis = new List<string>
{
    "casa", "pato", "bola", "gato", "livro", "mala", "fogo", "noite", "salto", "vento",
    "vaca", "dado", "vela", "copo", "cama", "peixe", "lindo", "limão", "tente", "tigre",
    "anjo", "boca", "nuvem", "troco", "mecha", "feira", "piano", "barco", "reino", "folha",
    "moeda", "fato", "minto", "papel", "cabra", "golpe", "sonho", "tempo", "amigo", "corda",
    "dedo", "farol", "linha", "pulga", "roupa", "trapo", "verão", "livre", "sinto", "mundo",
    "pedra", "garfo", "festa", "manga", "chave", "brisa", "touro", "pluma", "vinho", "couro",
    "cesto", "passe", "canal", "plano", "ponto", "marca", "ninho", "pinho", "posto", "faixa",
    "pasta", "banco", "cofre", "baixa", "lente", "morto", "fraco", "fosco", "longo", "feliz",
    "baixo", "colhe", "gosto", "vazio", "pesco", "macho", "misto", "cinto", "trave", "verde",
    "cinza", "sombra", "pente", "fundo", "curto", "ponta", "pulso", "surdo", "puxar", "virar"
};

static List<string> palavrasMedias = new List<string>
{
    "computador", "janela", "cadeado", "travesseiro", "violao", "garrafa", "camiseta", "cadeira", "bicicleta", "caderno",
    "montanha", "abelhinha", "lanterna", "cachorro", "lousa", "amarelo", "banheiro", "marcenaria", "disfarce", "espelho",
    "fogueira", "grampeador", "hamburguer", "inverno", "jacare", "lixeira", "mochila", "notebook", "oculos", "pincel",
    "quimono", "rabanete", "sapateira", "arvores", "urubu", "violenta", "xampu", "abacaxi", "bandeira", "cafeteira",
    "oculista", "escada", "fantasia", "guitarra", "hipnose", "igreja", "jantando", "limpeza", "marinheiro", "nebuloso",
    "oceano", "padeiro", "quintal", "refeicao", "sapato", "teclado", "uniforme", "velocidade", "aceleracao", "zangado",
    "abridor", "brinquedo", "canivete", "desenho", "editor", "farmacia", "gigante", "hepatite", "ideias", "jornal",
    "karate", "leopardo", "milagre", "navalha", "objetivo", "panqueca", "querido", "retrato", "sanduiche", "telefone",
    "urso", "vidraria", "xadrez", "zoologico", "avental", "balanço", "chaleira", "dentista", "escorpião", "fantoche",
    "gramado", "harpista", "icônico", "jovem", "lousado", "motorista", "narrador", "orquestra", "pintura", "quadrado"
};

static List<string> palavrasDificeis = new List<string>
{
    "otorrinolaringologista", "desenvolvimento", "responsabilidade", "inconstitucional", "hidroeletricidade",
    "extraordinario", "anticonstitucional", "caracteristico", "institucionalizado", "desproporcionalidade",
    "interdisciplinaridade", "infelizmente", "desencadeamento", "superficialidade", "significativo",
    "revolucionario", "psicopedagogia", "desestruturado", "caracteristicas", "constitucionalismo",
    "psiconeuroimunologia", "paleontologico", "excepcionalidade", "indiscriminado", "desconfortavel",
    "desclassificado", "desorganização", "perfeitamente", "inevitavelmente", "eventualmente",
    "irrefutavel", "imprevisivel", "ressignificação", "transcendentalismo", "irreversivel",
    "organizacional", "cientificamente", "potencialidade", "extraoficial", "transmutacional", "significativo",
    "reformulação", "desproporcional", "acidentalmente", "intercontinental", "ultrassonografia", "multidisciplinar",
    "multiculturalidade", "naturalistico", "irresponsavel", "incorretamente", "microestrutura",
    "agroindustrial", "hiperatividade", "retrospectiva", "transcontinental", "anticoncepcional", "ineficiência",
    "transmissivel", "revolucionarismo", "caracterização", "ambientalmente", "internacionalizar",
    "audiovisualidade", "neoliberalismo", "imparcialidade", "inexistência", "transcendentalidade",
    "multilateralidade", "sistematização", "superestimado", "organizacional", "desfavoravel",
    "libertariamente", "responsavelmente", "possivelmente", "fenomenalidade", "inoperacional", "microscopico",
    "transnacionalidade", "diferenciado", "objetivamente", "telecomunicações",
    "inconformado", "invulneravel", "regenerativo", "colaborativo", "inquestionavel"
};
    
    public static void Executar()
    {
        do {
            Console.Clear();
            Console.WriteLine("=== JOGO DA FORCA ===");
            Console.WriteLine("1 - Palavra do sistema");
            Console.WriteLine("2 - Outro jogador digita a palavra");
            Console.Write("Escolha: ");
            string tipo = Console.ReadLine();

            string palavra = "";

            if (tipo == "1")
            {
                int dificuldade = EscolherDificuldade();
                palavra = SelecionarPalavraDoSistema(dificuldade);
            }
            else
            {
                Console.Write("Jogador 2, digite a palavra para ser adivinhada: ");
                palavra = LerPalavraSecreta();
            }

            Jogar(palavra.ToLower());
            Console.Write("Deseja jogar novamente? (s/n): ");
        } while (Console.ReadLine().ToLower() == "s");
    }

    static int EscolherDificuldade()
    {
        Console.WriteLine("\nEscolha a dificuldade:");
        Console.WriteLine("1 - Fácil (4 a 5 letras)");
        Console.WriteLine("2 - Médio (6 a 9 letras)");
        Console.WriteLine("3 - Difícil (10+ letras)");
        Console.Write("Dificuldade: ");
        string op = Console.ReadLine();
        return op switch
        {
            "1" => 1,
            "2" => 2,
            "3" => 3,
            _ => 2
        };
    }

    static string SelecionarPalavraDoSistema(int dificuldade)
    {
        Random rand = new Random();
        return dificuldade switch
        {
            1 => palavrasFaceis[rand.Next(palavrasFaceis.Count)],
            2 => palavrasMedias[rand.Next(palavrasMedias.Count)],
            3 => palavrasDificeis[rand.Next(palavrasDificeis.Count)],
            _ => palavrasMedias[rand.Next(palavrasMedias.Count)]
        };
    }

    static string LerPalavraSecreta()
    {
        string palavra = "";
        do
        {
            palavra = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(palavra))
                Console.Write("Palavra inválida. Digite novamente: ");
        } while (string.IsNullOrWhiteSpace(palavra));

        Console.Clear();
        return palavra;
    }

    static void Jogar(string palavra)
    {
        HashSet<char> letrasCertas = new HashSet<char>();
        HashSet<char> letrasErradas = new HashSet<char>();
        int erros = 0;

        while (erros < 6)
        {
            ExibirBoneco(erros);
            MostrarPalavra(palavra, letrasCertas);
            Console.WriteLine($"Letras erradas: {string.Join(", ", letrasErradas)}");

            Console.Write("Escolha uma letra: ");
            string entrada = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(entrada) || entrada.Length != 1 || !char.IsLetter(entrada[0]))
            {
                Console.WriteLine("Entrada inválida. Digite apenas uma letra.");
                continue;
            }

            char letra = entrada[0];

            if (letrasCertas.Contains(letra) || letrasErradas.Contains(letra))
            {
                Console.WriteLine("Você já tentou essa letra.");
                continue;
            }

            if (palavra.Contains(letra))
                letrasCertas.Add(letra);
            else
            {
                letrasErradas.Add(letra);
                erros++;
            }

            if (PalavraCompleta(palavra, letrasCertas))
            {
                MostrarPalavra(palavra, letrasCertas);
                Console.WriteLine("Parabéns! Você venceu!");
                break;
            }
        }

        if (erros == 6)
        {
            ExibirBoneco(erros);
            Console.WriteLine($"Você perdeu! A palavra era: {palavra}");
        }
    }

    static void MostrarPalavra(string palavra, HashSet<char> letras)
    {
        Console.Write("Palavra: ");
        foreach (char c in palavra)
        {
            Console.Write(letras.Contains(c) ? c + " " : "_ ");
        }
        Console.WriteLine("\n");
    }

    static bool PalavraCompleta(string palavra, HashSet<char> letras)
    {
        foreach (char c in palavra)
        {
            if (!letras.Contains(c))
                return false;
        }
        return true;
    }

    static void ExibirBoneco(int erros)
    {
        string[] boneco = new string[7];
        boneco[0] = " _______";
        boneco[1] = " |     |";
        boneco[2] = erros >= 1 ? " |     O" : " |";
        boneco[3] = erros == 2 ? " |     |" :
                    erros == 3 ? " |    /|" :
                    erros >= 4 ? " |    /|\\" : " |";
        boneco[4] = erros == 5 ? " |    /" :
                    erros >= 6 ? " |    / \\" : " |";
        boneco[5] = " |";
        boneco[6] = "_|_";

        Console.Clear();
        foreach (var linha in boneco)
            Console.WriteLine(linha);
    }
}


class JogoDaVelha
{
    static char[] tabuleiro = new char[9];
    static char jogador1, jogador2;
    static int modoDeJogo;
    static int dificuldade;
    static Random rand = new Random();

    public static void Executar()
    {
        do
        {
            ReiniciarTabuleiro();

            Console.Clear();
            Console.WriteLine("=== JOGO DA VELHA ===");
            Console.WriteLine("1 - Um jogador");
            Console.WriteLine("2 - Dois jogadores");
            Console.Write("Modo: ");
            while (!int.TryParse(Console.ReadLine(), out modoDeJogo) || (modoDeJogo != 1 && modoDeJogo != 2))
            {
                Console.Write("Escolha 1 ou 2: ");
            }

            EscolherSimbolo();

            if (modoDeJogo == 1)
            {
                Console.WriteLine("Escolha a dificuldade:");
                Console.WriteLine("1 - Fácil");
                Console.WriteLine("2 - Normal");
                Console.WriteLine("3 - Difícil");
                Console.Write("Dificuldade: ");
                while (!int.TryParse(Console.ReadLine(), out dificuldade) || dificuldade < 1 || dificuldade > 3)
                {
                    Console.Write("Escolha entre 1 e 3: ");
                }
            }

            int rodada = 1;
            while (true)
            {
                ExibirTabuleiro();
                
                if (modoDeJogo == 2 || (modoDeJogo == 1 && rodada % 2 == 1))
                    JogadaHumana(rodada);
                else
                    JogadaComputador();

                if (VerificarVitoria())
                {
                    ExibirTabuleiro();
                    Console.WriteLine($"Vitória do jogador {(rodada % 2 == 1 ? jogador1 : jogador2)}!");
                    break;
                }

                if (rodada == 9)
                {
                    ExibirTabuleiro();
                    Console.WriteLine("Empate!");
                    break;
                }

                rodada++;
            }

            Console.Write("Deseja jogar novamente? (s/n): ");
        } while (Console.ReadLine().ToLower() == "s");
    }

    static void ReiniciarTabuleiro()
    {
        for (int i = 0; i < 9; i++)
            tabuleiro[i] = (char)('1' + i);
    }

    static void EscolherSimbolo()
    {
        Console.Write("Escolha seu símbolo (X ou O): ");
        while (true)
        {
            string input = Console.ReadLine().ToUpper();
            if (input == "X" || input == "O")
            {
                jogador1 = input[0];
                jogador2 = jogador1 == 'X' ? 'O' : 'X';
                break;
            }
            Console.Write("Inválido. Escolha X ou O: ");
        }
    }

    static void ExibirTabuleiro()
    {
        Console.Clear();
        Console.WriteLine($" {tabuleiro[0]} | {tabuleiro[1]} | {tabuleiro[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {tabuleiro[3]} | {tabuleiro[4]} | {tabuleiro[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {tabuleiro[6]} | {tabuleiro[7]} | {tabuleiro[8]} ");
        Console.WriteLine();
    }

    static void JogadaHumana(int rodada)
    {
        char simbolo = (modoDeJogo == 2) ? (rodada % 2 == 1 ? jogador1 : jogador2) : jogador1;

        Console.Write($"Jogador ({simbolo}), posição (1-9): ");
        int pos;
        while (!int.TryParse(Console.ReadLine(), out pos) || pos < 1 || pos > 9 || tabuleiro[pos - 1] == jogador1 || tabuleiro[pos - 1] == jogador2)
        {
            Console.Write("Inválido. Tente novamente: ");
        }
        tabuleiro[pos - 1] = simbolo;
    }

    static void JogadaComputador()
    {
        Console.WriteLine("Computador está jogando...");
        System.Threading.Thread.Sleep(1000);

        int chance = rand.Next(100);
        int prob = dificuldade switch { 1 => 50, 2 => 75, 3 => 90, _ => 75 };
        int pos = -1;

        if (chance < prob)
        {
            pos = JogadaVencedora(jogador2);
            if (pos == -1) pos = JogadaVencedora(jogador1);
            if (pos == -1 && tabuleiro[4] != jogador1 && tabuleiro[4] != jogador2) pos = 4;
            if (pos == -1)
            {
                foreach (int i in new[] { 0, 2, 6, 8 })
                    if (tabuleiro[i] != jogador1 && tabuleiro[i] != jogador2) { pos = i; break; }
            }
        }

        if (pos == -1)
        {
            do { pos = rand.Next(9); }
            while (tabuleiro[pos] == jogador1 || tabuleiro[pos] == jogador2);
        }

        tabuleiro[pos] = jogador2;
    }

    static int JogadaVencedora(char simbolo)
    {
        int[,] vitorias = {
            {0, 1, 2},{3, 4, 5},{6, 7, 8},
            {0, 3, 6},{1, 4, 7},{2, 5, 8},
            {0, 4, 8},{2, 4, 6}
        };

        for (int i = 0; i < 8; i++)
        {
            int a = vitorias[i,0], b = vitorias[i,1], c = vitorias[i,2];
            if (tabuleiro[a] == simbolo && tabuleiro[b] == simbolo && Livre(c)) return c;
            if (tabuleiro[a] == simbolo && tabuleiro[c] == simbolo && Livre(b)) return b;
            if (tabuleiro[b] == simbolo && tabuleiro[c] == simbolo && Livre(a)) return a;
        }
        return -1;
    }

    static bool Livre(int i) => tabuleiro[i] != jogador1 && tabuleiro[i] != jogador2;

    static bool VerificarVitoria()
    {
        int[,] vitorias = {
            {0, 1, 2},{3, 4, 5},{6, 7, 8},
            {0, 3, 6},{1, 4, 7},{2, 5, 8},
            {0, 4, 8},{2, 4, 6}
        };

        for (int i = 0; i < vitorias.GetLength(0); i++) {
            int a = vitorias[i, 0], b = vitorias[i, 1], c = vitorias[i, 2];
            if (tabuleiro[a] == tabuleiro[b] && tabuleiro[b] == tabuleiro[c])
                return true;
        }

        return false;
    }
} 

class Program{
    static void Main(){
        
        
        while (true){
            MostrarMenu();
		
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    JogoDaVelha.Executar();
                    break;
                    
                case "2":
                    Forca.Executar();
                    break;

                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("⚠️ Opção inválida. Tente novamente.\n");
                    break;
            }
        }
    }
    static void MostrarMenu()
    {
        Console.WriteLine("\n=== Menu Principal ===");
        Console.WriteLine("[1] Jogo da Velha");
        Console.WriteLine("[2] Jogo da Forca");
        Console.WriteLine("[0] Sair");
    }

}