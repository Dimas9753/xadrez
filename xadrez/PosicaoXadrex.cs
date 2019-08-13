using tabuleiro;
namespace xadrez
{
    public class PosicaoXadrex
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrex(char _coluna, int _linha)
        {
          coluna = _coluna;
          linha = _linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao( 8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

    }
}