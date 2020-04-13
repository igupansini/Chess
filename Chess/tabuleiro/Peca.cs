namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int quantidadeMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.quantidadeMovimentos = 0;
        }

        public void incrementarMovimento()
        {
            quantidadeMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
