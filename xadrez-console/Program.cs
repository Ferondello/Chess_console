using tabuleiro;
using xadrez_console.xadrez;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);



            Console.ReadLine();
        }
    }
}
