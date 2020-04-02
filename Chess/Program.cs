using System;
using tabuleiro;
using xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de Xadrez");
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(2, 5));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(1, 4));

            Tela.imprimirTabuleiro(tabuleiro);

        }
    }
}
