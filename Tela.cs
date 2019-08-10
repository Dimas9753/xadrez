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
             for (int j = 0; j < _tabuleiro.colunas; j++)
             {
                 if (_tabuleiro.peca(i,j) == null)
                 {
                     System.Console.Write($"- ");
                 }
                 else
                 {
                     System.Console.Write($"{_tabuleiro.peca(i,j)} ");
                 }
             }
             System.Console.WriteLine();
         }
      }  
    }
}