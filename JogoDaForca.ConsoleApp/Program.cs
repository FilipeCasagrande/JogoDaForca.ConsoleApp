namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //versão 2.0: exibir bapavra oculta com traços
        static void Main(string[] args)
        {
            while (true)
            {

                string palavrasecreta = "MELANCIA";

                char[] letrasencontradas = new char[palavrasecreta.Length]; 

                for(int caractere =0; caractere < letrasencontradas.Length; caractere++)
                {
                    letrasencontradas[caractere] = '_';
                }

                string dicadapalavra = String.Join(" ", letrasencontradas)
                
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Palavra secreata " + palavrasecreta);
                Console.WriteLine("---------------------------------------");

                //obtem apenas 1 caracter

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];
                Console.WriteLine(chute);
                Console.ReadLine();





            }
            
        }
    }
}
