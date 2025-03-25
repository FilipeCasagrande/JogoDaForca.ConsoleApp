namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //versão 1.0: Estrutura basica
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Jogo da Forca");
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
