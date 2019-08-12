using System.Threading;
namespace tabuleiro
{
    public class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // <-- Matriz de pecas

        public Tabuleiro(int _linhas, int _colunas)
        {
          linhas = _linhas;
          colunas = _colunas;
          pecas = new Peca[linhas,colunas];
        }

        public Peca peca(int _linha, int _coluna)
        {
          return pecas[_linha,_coluna];
        }

        public Peca peca(Posicao _pos)
        {
          return pecas[_pos.linha,_pos.coluna];
        }

        public bool ExistePeca(Posicao _pos)
        {
          ValidarPosicao(_pos);
          return peca(_pos) != null;
        }

        public void ColocarPeca(Peca _p, Posicao _pos)
        {
          if (ExistePeca(_pos))
          {
              throw new System.Exception("JA EXISTE UMA PEÇA NESSA POSIÇÃO!");
          }
          pecas[_pos.linha,_pos.coluna] = _p;
          _p.posicao = _pos;
        }

        public bool PosicaoValida(Posicao _pos)
        {
          if (_pos.linha < 0 || _pos.linha >= linhas || _pos.coluna <0 || _pos.coluna >= colunas)
          {
              return false;
          }
          return true;
        }

        public void ValidarPosicao(Posicao _pos)
        {
          if (!PosicaoValida(_pos))
          {
              throw new System.Exception("POSIÇÃO INVALIDA!");
          }
        }

    }
}