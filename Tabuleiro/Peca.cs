namespace tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor  { get; protected set; }
        public int qtdmovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }


    public Peca(Cor _cor, Tabuleiro _tabuleiro)
    {
        posicao = null;
        cor = _cor;
        tabuleiro = _tabuleiro;
        qtdmovimentos = 0;
    }

    public void IncrementarQtdMovimento()
    {
        qtdmovimentos++;
    }

    
    }
}