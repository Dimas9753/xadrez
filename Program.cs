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
            
            System.Console.WriteLine(pos);
            System.Console.WriteLine(pos.toPosicao());
            
            
            /*
            try
            {
            Tabuleiro tab = new Tabuleiro(8,8);
           
            tab.ColocarPeca(new Torre(Cor.Vermelho, tab), new Posicao(0,0));
            tab.ColocarPeca(new Rei(Cor.Vermelho, tab), new Posicao(7,7));
            tab.ColocarPeca(new Torre(Cor.Vermelho, tab), new Posicao(0,0));

            Tela.ImprimirTabuleiro(tab);
            }catch(TabuleiroException e)
            {
               System.Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            */
        }
    }
}
