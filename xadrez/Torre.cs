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

        private bool PodeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
           bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
           Posicao pos = new Posicao(0,0);
          
           //Norte
           pos.DefinirValores(posicao.linha -1, posicao.coluna);
           while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
               if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
               {
                   break;
               }
               pos.linha = pos.linha -1;
           }

            //Leste
           pos.DefinirValores(posicao.linha , posicao.coluna +1);
           while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
               if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
               {
                   break;
               }
               pos.coluna = pos.coluna +1;
           }

            //Sul
           pos.DefinirValores(posicao.linha +1, posicao.coluna);
           while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
               if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
               {
                   break;
               }
               pos.linha = pos.linha +1;
           }

            //Oeste
           pos.DefinirValores(posicao.linha , posicao.coluna -1);
           while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
               if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
               {
                   break;
               }
               pos.coluna = pos.coluna -1;
           }
           
           return mat;
        }
    }
}