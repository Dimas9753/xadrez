using System;
using tabuleiro;

namespace Xadrez_Console
{
    public class Tela
    {
      public static void ImprimirTabuleiro(Tabuleiro _tabuleiro)
      {
         for (int i = 0; i < _tabuleiro.linhas; i++)
         {
             System.Console.Write(8 - i + " " );
             for (int j = 0; j < _tabuleiro.colunas; j++)
             {
                 if (_tabuleiro.peca(i,j) == null)
                 {
                     System.Console.Write($"- ");
                 }
                 else
                 {
                     ImprimirPeca(_tabuleiro.peca(i,j));
                     System.Console.Write("");
                     //System.Console.Write($"{_tabuleiro.peca(i,j)} ");
                 }
             }
             System.Console.WriteLine();
        }
         System.Console.Write("  A B C D E F H G");
      }  

      public static void ImprimirPeca(Peca _peca)
      {
          if (_peca.cor == Cor.Amarelo)
          {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write($"{_peca} ");
            Console.ForegroundColor = aux;
          }
          else
          {
            ConsoleColor aux2 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write($"{_peca} ");
            Console.ForegroundColor = aux2;
          }
      }
    }

}