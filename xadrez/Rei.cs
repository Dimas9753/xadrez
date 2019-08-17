using System;
using tabuleiro;

namespace xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor _cor, Tabuleiro _tabuleiro): base(_cor,_tabuleiro)
        {

        }

        public override string ToString()
        {
            return "R";
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
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Nordeste
           pos.DefinirValores(posicao.linha -1, posicao.coluna +1);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Leste
           pos.DefinirValores(posicao.linha, posicao.coluna +1);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Sudeste
           pos.DefinirValores(posicao.linha +1, posicao.coluna +1);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Sul
           pos.DefinirValores(posicao.linha +1, posicao.coluna);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Sudoeste
           pos.DefinirValores(posicao.linha +1, posicao.coluna -1);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Oeste
           pos.DefinirValores(posicao.linha , posicao.coluna -1);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           //Noroeste
           pos.DefinirValores(posicao.linha -1, posicao.coluna -1);
           if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.linha,pos.coluna] = true;
           }

           return mat;


        }
    }
}