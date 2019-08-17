namespace tabuleiro
{
    public abstract class Peca
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

    public bool ExisteMovimentosPossiveis()
    {
        bool[,] mat = MovimentosPossiveis();
        for (int i = 0; i < tabuleiro.linhas; i++)
        {
            for (int j = 0; j < tabuleiro.colunas; j++)
            {
               if (mat[i,j])
               {
                   return true;
               } 
            }
        }

        return false;
    }

    public bool PodeMover(Posicao _pos)
    {
        return MovimentosPossiveis() [_pos.linha,_pos.coluna];
    }

    public abstract bool[,] MovimentosPossiveis();
  

    
    }
}