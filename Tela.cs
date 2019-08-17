using System;
using tabuleiro;
using xadrez;

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
                ImprimirPeca(_tabuleiro.peca(i,j));
                System.Console.Write("");
             }
             System.Console.WriteLine();
        }
         System.Console.Write("  A B C D E F G H");
      }  

      public static void ImprimirTabuleiro(Tabuleiro _tabuleiro, bool[,] posicoespossiveis)
      {
        ConsoleColor fundooriginal = Console.BackgroundColor;
        ConsoleColor fundoalterado = ConsoleColor.DarkGray;

         for (int i = 0; i < _tabuleiro.linhas; i++)
         {
             System.Console.Write(8 - i + " " );
             for (int j = 0; j < _tabuleiro.colunas; j++)
             {
               if (posicoespossiveis[i,j] == true)
               {
                   Console.BackgroundColor = fundoalterado;
               }
               else
               {
                 Console.BackgroundColor = fundooriginal;
               }
                ImprimirPeca(_tabuleiro.peca(i,j));
               // System.Console.Write("");
               Console.BackgroundColor = fundooriginal;
             }
             System.Console.WriteLine();
        }
         System.Console.Write("  A B C D E F G H");
         Console.BackgroundColor = fundooriginal;
      }  


      public static PosicaoXadrez LerPosicaoXadrez()
      {
         string s = Console.ReadLine();
         char coluna = s[0];
         int linha = int.Parse(s[1] + "");
         return new PosicaoXadrez(coluna,linha);
      }

      public static void ImprimirPeca(Peca _peca)
      {
         
       if (_peca == null)
       {
         System.Console.Write($"- ");
       }
       else
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

        System.Console.Write("");
       }
     
      }


    }

}