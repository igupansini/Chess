namespace tabuleiro
{
    class Posicao
    {
        private int linha { get; set; }
        private int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha + ", " + coluna;
        }
    }
}
