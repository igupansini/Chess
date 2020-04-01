using System;
using tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de Xadrez");
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tabuleiro);

        }
    }
}
