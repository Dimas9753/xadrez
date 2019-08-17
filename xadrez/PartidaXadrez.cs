using tabuleiro;
namespace xadrez
{
    public class PartidaXadrez
    {
        public Tabuleiro tabuleiro {get; private set;}
        public int turno {get; private set;}
        public Cor jogadoratual {get; private set;}
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

        public void RealizaJogada(Posicao _origem, Posicao _destino)
        {
            ExecutaMovimento(_origem,_destino);
            turno++;
            MudaJogador();
        }

        public void ValidarPosicaoOrigem(Posicao _pos)
        {
            if (tabuleiro.peca(_pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição selecionanda!!, TECLE ENTER!");
            }
            if (jogadoratual != tabuleiro.peca(_pos).cor)
            {
                throw new TabuleiroException("A peça selecionada não é sua!!, TECLE ENTER!");
            }
            if (!tabuleiro.peca(_pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não ha movimentos possiveis para a peça selecionada!!, TECLE ENTER!");
            }
        }

         public void ValidarPosicaoDestino(Posicao _origem, Posicao _destino)
        {
            if (!tabuleiro.peca(_origem).PodeMover(_destino))
            {
                throw new TabuleiroException("Posição de destino invalida!!, TECLE ENTER!");
            }
        }

        public void MudaJogador()
        {
            if (jogadoratual == Cor.Amarelo)
            {
                jogadoratual = Cor.Vermelho;
            }
            else
            {
                jogadoratual = Cor.Amarelo;
            }
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