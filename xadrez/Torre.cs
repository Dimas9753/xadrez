using System;
using tabuleiro;
namespace xadrez
{
    public class Torre : Peca
    {
        public Torre(Cor _cor, Tabuleiro _tabuleiro): base(_cor,_tabuleiro)
        {

        }

        public override String ToString()
        {
            return "T";
        }
    }
}