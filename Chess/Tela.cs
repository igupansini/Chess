using tabuleiro;
using System;

namespace Chess
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("-  ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tabuleiro.peca(i, j));
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n   a  b  c  d  e  f  g  h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
