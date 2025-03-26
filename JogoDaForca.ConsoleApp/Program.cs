namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //versão implementar verificação de dados se esta na palavra
        static void Main(string[] args)
        {
            while (true)
            {
                string palavrasecreta = "uva";

                char[] letrasencontradas = new char[palavrasecreta.Length];

                for (int caractere = 0; caractere < letrasencontradas.Length; caractere++)
                {
                    letrasencontradas[caractere] = '_';
                }



                int quantidadedeerros = 0;
                bool jogadorenforcou = false;
                bool jogadoracertou = false;


                do
                {
                    string dicadapalavra = String.Join("" ,letrasencontradas);
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Palavra secreata " + dicadapalavra);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Quantiadade de erros: " + quantidadedeerros);
                    Console.WriteLine("---------------------------------------");


                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0];

                    bool Letrafoiencontrada = false;

                    for ( int contador = 0; contador < palavrasecreta.Length; contador++)
                    {
                        char letraatual = palavrasecreta[contador];
                        
                        if (chute == letraatual)
                        {
                            letrasencontradas[contador] = letraatual;
                            Letrafoiencontrada = true;
                        }
                    }
                    if (Letrafoiencontrada == false)
                        quantidadedeerros++;
                    
                    
                    dicadapalavra = String.Join(" ", letrasencontradas);

                    jogadoracertou = dicadapalavra == palavrasecreta;

                    jogadorenforcou = quantidadedeerros > 5;

                    if (jogadoracertou)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("você acertou a palavra secreta era" + palavrasecreta);
                        Console.WriteLine("---------------------------------------");
                    }
                    else if (jogadorenforcou)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Que azar, tente novamente");
                        Console.WriteLine("---------------------------------------");
                    }
                } while (jogadoracertou == false && jogadorenforcou == false);   

                Console.ReadLine();

            }

        }
    }
}
