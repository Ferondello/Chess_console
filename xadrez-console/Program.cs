using tabuleiro;
using xadrez_console.xadrez;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
