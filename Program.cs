using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrex pos = new PosicaoXadrex('a' , 1);
            
            try
            {
            Tabuleiro tab = new Tabuleiro(8,8);
           
            tab.ColocarPeca(new Torre(Cor.Vermelho, tab), new Posicao(0,0));
            tab.ColocarPeca(new Rei(Cor.Vermelho, tab), new Posicao(2,5));
            tab.ColocarPeca(new Torre(Cor.Vermelho, tab), new Posicao(3,2));

            tab.ColocarPeca(new Torre(Cor.Amarelo, tab), new Posicao(6,5));
            tab.ColocarPeca(new Rei(Cor.Amarelo, tab), new Posicao(6,6));
            tab.ColocarPeca(new Torre(Cor.Amarelo, tab), new Posicao(4,1));

            Tela.ImprimirTabuleiro(tab);
            }catch(TabuleiroException e)
            {
               System.Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            
        }
    }
}
