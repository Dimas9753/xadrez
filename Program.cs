using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
           
            tab.ColocarPeca(new Torre(Cor.Vermelho, tab), new Posicao(0,0));
            tab.ColocarPeca(new Rei(Cor.Vermelho, tab), new Posicao(7,7));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
