namespace tabuleiro
{
    class Peca
    {
        private Posicao posicao { get; set; }
        private Cor cor { get; set; }
        private int quantidadeMovimentos { get; set; }
        private Tabuleiro tabuleiro { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.quantidadeMovimentos = 0;
        }
    }
}
