using System;
using tabuleiro;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de Xadrez");
            Posicao p1 = new Posicao(3, 5);
            Console.WriteLine(p1);
        }
    }
}
