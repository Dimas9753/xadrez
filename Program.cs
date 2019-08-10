using System;
using tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8,8);
            //Console.WriteLine("Posicao " + t);

            Tela.ImprimirTabuleiro(t);

            Console.ReadLine();
        }
    }
}
