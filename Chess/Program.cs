using System;
using tabuleiro;
using xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Console.WriteLine("\t CHESS\n");
                    Tela.imprimirTabuleiro(partida.tab);
                    
                    Console.WriteLine("\nORIGEM: ");
                    Posicao origem = Tela.lerPosicao().toPosicao();
                    Console.WriteLine("\nDESTINO: ");
                    Posicao destino = Tela.lerPosicao().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
