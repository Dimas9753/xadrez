using System;
using tabuleiro;
namespace xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor _cor, Tabuleiro _tabuleiro): base(_cor,_tabuleiro)
        {

        }

        public override String ToString()
        {
            return "R";
        }
    }
}