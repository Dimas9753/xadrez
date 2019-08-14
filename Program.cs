using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a' , 1);
            
            try
            {
             PartidaXadrez partida = new PartidaXadrez();
           
             while (!partida.terminada)
             {
                 Console.Clear();
                 Tela.ImprimirTabuleiro(partida.tabuleiro);
                 
                 System.Console.WriteLine();
                 System.Console.WriteLine();

                 System.Console.Write("Origem: ");
                 Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
             
                 System.Console.Write("Destino: ");
                 Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
           
                 partida.ExecutaMovimento(origem,destino);
             }
           

             Tela.ImprimirTabuleiro(partida.tabuleiro);
            }catch(TabuleiroException e)
            {
               System.Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            
        }
    }
}
