
class DesafioJogoDaVelha
{
    public static void jogoDaVelhaPvPC()
    {
        char[,] tabuleiro = new char[3, 3];
        string[] vetorJogada = new string[2];
        int contadorJogo = 0, resposta;
        bool fimDeJogo = false;

        do
        {
            if (contadorJogo == 0) //Inicializando o tabuleiro
            {
                inicializarTabuleiro(tabuleiro);
            }

            realizarJogadaPc(tabuleiro, contadorJogo); //Realizando a jogada do Computador
            contadorJogo++;

            printTabuleiro(tabuleiro);

            fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, false); //Verificando se alguém ganhou



            if (!fimDeJogo)
            {
                realizarJogadaP(tabuleiro); //Realizando a jogada do Jogador
                contadorJogo++;

                printTabuleiro(tabuleiro);

                fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, false);
            }

            if (fimDeJogo) //Checando se o usuário deseja jogar novamente
            {
                Console.WriteLine("Deseja jogar novamente? (1 para sim, qualquer tecla para não)");
                Console.Write("Opção: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta != 1)
                {
                    Console.WriteLine("Obrigado por jogar! Saindo do sistema...\n");
                    break;
                }
                else
                {
                    contadorJogo = 0;
                    fimDeJogo = false;
                }
            }

        } while (true);
    }


    static void printTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]} ");
    }

    static void inicializarTabuleiro(char[,] tabuleiro)
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }

        Console.WriteLine("\nJOGO DA VELHA\n");
        printTabuleiro(tabuleiro);
    }

    static void realizarJogadaP(char[,] tabuleiro)
    {
        int jogada, contador = 0;

        while (true)
        {
            Console.WriteLine($"\nJogador (X) em que posição deseja jogar: ");
            jogada = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    contador++;
                    if (contador == jogada)
                    {
                        if (tabuleiro[i, j] != ' ')
                        {
                            Console.WriteLine("Posição preenchida! Tente novamente.");
                        }
                        else
                        {
                            tabuleiro[i, j] = 'X';
                            break;
                        }
                    }
                }
            }

        }
    }

    static void realizarJogadaPc(char[,] tabuleiro, int contadorJogo)
    {
        int jogadaPC;
        Random randomint = new Random();

        jogadaPC = randomint.Next(0, 10);
    }

    static bool verificaGanhador(char[,] tabuleiro, int contadorJogo, bool fimDeJogo)
    {
        fimDeJogo = verificaLinhas(tabuleiro, false); //Verificando se alguem ganhou nas linhas

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaColunas(tabuleiro, false); //Verificando se alguem ganhou nas colunas
        }

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaDiagonalPrincipal(tabuleiro, false); //Verificando se alguem ganhou na diagonal principal
        }

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaDiagonalInversa(tabuleiro, false); //Verificando se alguem ganhou na diagonal inversa
        }

        if (contadorJogo == 9)
        {
            Console.WriteLine("--- Deu velha! ---");
            fimDeJogo = true;
        }

        return fimDeJogo;
    }

    static bool verificaLinhas(char[,] tabuleiro, bool fimDeJogo)
    {
        for (int i = 0; i < 3; i++)
        {
            int contadorJ1 = 0;
            int contadorJ2 = 0;
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == 'X')
                {
                    contadorJ1++;
                }
                else if (tabuleiro[i, j] == 'O')
                {
                    contadorJ2++;
                }
            }
            if (contadorJ1 == 3)
            {
                Console.WriteLine("--- 1º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorJ2 == 3)
            {
                Console.WriteLine("--- 2º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }

    static bool verificaColunas(char[,] tabuleiro, bool fimDeJogo)
    {
        for (int i = 0; i < 3; i++)
        {
            int contadorJ1 = 0;
            int contadorJ2 = 0;
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[j, i] == 'X')
                {
                    contadorJ1++;
                }
                else if (tabuleiro[j, i] == 'O')
                {
                    contadorJ2++;
                }
            }
            if (contadorJ1 == 3)
            {
                Console.WriteLine("--- 1º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorJ2 == 3)
            {
                Console.WriteLine("--- 2º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }

    static bool verificaDiagonalPrincipal(char[,] tabuleiro, bool fimDeJogo)
    {
        int contadorJ1 = 0;
        int contadorJ2 = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        contadorJ1++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        contadorJ2++;
                    }
                }
            }
            if (contadorJ1 == 3)
            {
                Console.WriteLine("--- 1º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorJ2 == 3)
            {
                Console.WriteLine("--- 2º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }

    static bool verificaDiagonalInversa(char[,] tabuleiro, bool fimDeJogo)
    {
        int contadorJ1 = 0;
        int contadorJ2 = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i + j == 2)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        contadorJ1++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        contadorJ2++;
                    }
                }
            }
            if (contadorJ1 == 3)
            {
                Console.WriteLine("--- 1º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorJ2 == 3)
            {
                Console.WriteLine("--- 2º Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }
}