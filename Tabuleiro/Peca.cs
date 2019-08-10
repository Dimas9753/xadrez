namespace tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor  { get; protected set; }
        public int qtdmovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }


    public Peca(Posicao _posicao, Cor _cor, Tabuleiro _tabuleiro)
    {
        posicao = _posicao;
        cor = _cor;
        tabuleiro = _tabuleiro;
        qtdmovimentos = 0;
    }

    
    }
}