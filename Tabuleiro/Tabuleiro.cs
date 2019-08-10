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

    }
}