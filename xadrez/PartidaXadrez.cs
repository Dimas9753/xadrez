using tabuleiro;
namespace xadrez
{
    public class PartidaXadrez
    {
        public Tabuleiro tabuleiro {get; private set;}
        private int turno;
        private Cor jogadoratual;
        public bool terminada { get; private set; }

        public PartidaXadrez()
        {
            tabuleiro = new Tabuleiro(8,8);
            turno = 1;
            jogadoratual = Cor.Amarelo;
            terminada = false;
            ColocarPeca();
        }

        public void ExecutaMovimento(Posicao _origem, Posicao _destino)
        {
            Peca p = tabuleiro.RetirarPeca(_origem);
            p.IncrementarQtdMovimento();
            Peca pecacapturada = tabuleiro.RetirarPeca(_destino);
            tabuleiro.ColocarPeca(p, _destino);
        }

        private void ColocarPeca()
        {
            tabuleiro.ColocarPeca(new Torre(Cor.Vermelho, tabuleiro), new PosicaoXadrez('c',8).toPosicao());
            tabuleiro.ColocarPeca(new Rei(Cor.Vermelho, tabuleiro), new PosicaoXadrez('d',8).toPosicao());
            tabuleiro.ColocarPeca(new Torre(Cor.Vermelho, tabuleiro), new PosicaoXadrez('e',8).toPosicao());

            tabuleiro.ColocarPeca(new Torre(Cor.Amarelo, tabuleiro), new PosicaoXadrez('c',1).toPosicao());
            tabuleiro.ColocarPeca(new Rei(Cor.Amarelo, tabuleiro), new PosicaoXadrez('d',1).toPosicao());
            tabuleiro.ColocarPeca(new Torre(Cor.Amarelo, tabuleiro), new PosicaoXadrez('e',1).toPosicao());
        }
    }
}