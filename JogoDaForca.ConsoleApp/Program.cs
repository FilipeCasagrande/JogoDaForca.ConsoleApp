namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //versão implementar verificação de dados se esta na palavra
        static void Main(string[] args)
        {
            while (true)
            {
                string[] palavrasecreta = { "abacate","abacaxi","acerola", "acai", "araca","goiaba","maca"};

                Random random = new Random();

                int indice = random.Next(palavrasecreta.Length);

                string palavraescolhida = palavrasecreta[indice];

                char[] letrasencontradas = new char[palavrasecreta.Length];

                for (int caractere = 0; caractere < palavraescolhida.Length; caractere++)
                
                    letrasencontradas[caractere] = '_';
             

                int quantidadedeerros = 0;
                bool jogadorenforcou = false;
                bool jogadoracertou = false;

                do
                {
                    string dicadapalavra = String.Join("", letrasencontradas);
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Palavra secreata " + dicadapalavra);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Quantiadade de erros: " + quantidadedeerros);
                    Console.WriteLine("---------------------------------------");
                    if (quantidadedeerros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadedeerros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadedeerros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |         |        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadedeerros == 3)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /|        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadedeerros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine("          /|\\       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (quantidadedeerros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /|\\       ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0];


                    bool Letrafoiencontrada = false;

                    for (int contador = 0; contador < palavraescolhida.Length; contador++)
                    {
                        char letraatual = palavraescolhida[contador];

                        if (chute == letraatual)
                        {
                            letrasencontradas[contador] = letraatual;
                            Letrafoiencontrada = true;
                        }
                    }
                    if (Letrafoiencontrada == false)
                        quantidadedeerros++;


                    dicadapalavra = String.Join("", letrasencontradas);

                    jogadoracertou = dicadapalavra == palavraescolhida;

                    jogadorenforcou = quantidadedeerros > 5;

                    if (jogadoracertou)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("você acertou a palavra secreta era: " + palavrasecreta[indice]);
                        Console.WriteLine("---------------------------------------");
                    }
                    else if (jogadorenforcou)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Que azar, tente novamente");
                        Console.WriteLine("---------------------------------------");
                    }
                } while (jogadoracertou == false && jogadorenforcou == false);

                Console.WriteLine("Deseja continuar o jogo [S/N]?");
                string opcaocontinuar = Console.ReadLine();
                if (opcaocontinuar == "n")
                {
                    break;
                }

            }

        }
    }
}
