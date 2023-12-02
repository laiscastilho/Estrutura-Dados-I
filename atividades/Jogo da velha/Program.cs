using System;

class JogoDaVelha
{
    private static Random random = new Random();
    private static char[,] Jogo = new char[3, 3];

    static void Main()
    {
        PreencherJogadas();
        MostrarJogo();
        ConferirVencedor(Jogo);
    }

    static void MostrarJogo()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(Jogo[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PreencherJogadas()
    {
        int contX = 0;
        int contO = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                char jogada = GerarJogada();
                Jogo[i, j] = jogada;

                if (jogada == 'X')
                {
                    contX++;
                }
                else
                {
                    contO++;
                }

                // Garante que ambos os jogadores têm a mesma quantidade de jogadas
                if (contX > 4 && contX == contO)
                {
                    Jogo[i, j] = GerarJogada('O');
                }
            }
        }
    }

    static char GerarJogada(char jogador = 'X')
    {
        return (random.Next(2) == 0) ? jogador : (jogador == 'X' ? 'O' : 'X');
    }

    static void ConferirVencedor(char[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            if (matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2] && matriz[i, 0] != '\0')
            {
                Console.WriteLine($"O vencedor é: {matriz[i, 0]}!");
                return;
            }

            if (matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i] && matriz[0, i] != '\0')
            {
                Console.WriteLine($"O vencedor é: {matriz[0, i]}!");
                return;
            }
        }

        if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] && matriz[0, 0] != '\0')
        {
            Console.WriteLine($"O vencedor é: {matriz[0, 0]}!");
            return;
        }

        if (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0] && matriz[0, 2] != '\0')
        {
            Console.WriteLine($"O vencedor é: {matriz[0, 2]}!");
            return;
        }

        Console.WriteLine("Ninguém venceu.");
    }
}