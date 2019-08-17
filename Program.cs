using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           // PosicaoXadrez pos = new PosicaoXadrez('a' , 1);
            
            try
            {
             PartidaXadrez partida = new PartidaXadrez();
           
             while (!partida.terminada)
             {
                 try
                 {
                 Console.Clear();
                 Tela.ImprimirTabuleiro(partida.tabuleiro);
                 System.Console.WriteLine();
                 System.Console.WriteLine();
                 System.Console.WriteLine($"TURNO: {partida.turno}");
                 System.Console.WriteLine($"AGUARDANDO JOGADA: {partida.jogadoratual}");

                 System.Console.WriteLine();

                 System.Console.Write("Origem: ");
                 Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                 partida.ValidarPosicaoOrigem(origem);
                 
                 bool[,] posicoespossiveis = partida.tabuleiro.peca(origem).MovimentosPossiveis();
                 

                 Console.Clear();
                 Tela.ImprimirTabuleiro(partida.tabuleiro, posicoespossiveis);
                 
                 System.Console.WriteLine();
                 System.Console.WriteLine();

                 System.Console.Write("Destino: ");
                 Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                 partida.ValidarPosicaoDestino(origem,destino);

                 partida.RealizaJogada(origem,destino);
                 }
                   catch(TabuleiroException e)
                   {
                       System.Console.WriteLine(e.Message);
                       Console.ReadKey();
                   }
             
             }
             
            }              //Tela.ImprimirTabuleiro(partida.tabuleiro);
             catch(TabuleiroException e)
             {
               System.Console.WriteLine(e.Message);
             }

            Console.ReadLine();
            
        }
    }
}
