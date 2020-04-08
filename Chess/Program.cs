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
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
        }
    }
}
