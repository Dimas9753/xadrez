using tabuleiro;
namespace xadrez
{
    public class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char _coluna, int _linha)
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