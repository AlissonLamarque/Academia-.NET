/* 
1) Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
2) Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. 
3) Após cada jogada, apresente o tabuleiro com as jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
4) Caso seja empate, apresente o resultado na tela. 
5) Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo.

Extra:
1) Faça a implementação de um jogo contra o computador. 
2) Faça o possível para evitar que o jogador vença do computador. 
3) Para facilitar, faça com que o computador inicie jogando.
*/


public class DesafioJogoDaVelha
{
    public static void Main()
    {
        int op;

        do
        {
            Console.Clear();
            Console.WriteLine("\r\n     ██╗ ██████╗  ██████╗  ██████╗     ██████╗  █████╗     ██╗   ██╗███████╗██╗     ██╗  ██╗ █████╗ \r\n     ██║██╔═══██╗██╔════╝ ██╔═══██╗    ██╔══██╗██╔══██╗    ██║   ██║██╔════╝██║     ██║  ██║██╔══██╗" +
                "\r\n     ██║██║   ██║██║  ███╗██║   ██║    ██║  ██║███████║    ██║   ██║█████╗  ██║     ███████║███████║\r\n██   ██║██║   ██║██║   ██║██║   ██║    ██║  ██║██╔══██║    ╚██╗ ██╔╝██╔══╝  ██║     ██╔══██║██╔══██║\r\n╚█████╔╝╚██████╔╝" +
                "╚██████╔╝╚██████╔╝    ██████╔╝██║  ██║     ╚████╔╝ ███████╗███████╗██║  ██║██║  ██║\r\n ╚════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝  ╚═╝      ╚═══╝  ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝\r\n                                        " +
                "                                                            \r\n");

            Console.Write("Que modo deseja jogar?\n1 - P vs P\n2 - P vs PC\n3 - Sair\nSua opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    PvP();
                    break;
                case 2:
                    PvPC();
                    break;
                case 3:
                    Console.WriteLine("Obrigado por jogar! Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (op != 3);
    }

    public static void PvP()
    {
        char[,] tabuleiro = new char[3, 3];
        int contadorJogo = 0, resposta;
        bool fimDeJogo = false;

        do
        {
            if (contadorJogo == 0) //Inicializando o tabuleiro
            {
                inicializarTabuleiro(tabuleiro);
            }

            realizarJogada(tabuleiro, 1); //Realizando a jogada do 1º Jogador
            contadorJogo++;

            printTabuleiro(tabuleiro);

            fimDeJogo = verificaGanhadorPvP(tabuleiro, contadorJogo, false); //Verificando se alguém ganhou



            if (!fimDeJogo)
            {
                realizarJogada(tabuleiro, 2); //Realizando a jogada do 2º Jogador
                contadorJogo++;

                printTabuleiro(tabuleiro);

                fimDeJogo = verificaGanhadorPvP(tabuleiro, contadorJogo, false);
            }

            if (fimDeJogo) //Checando se o usuário deseja jogar novamente
            {
                Console.WriteLine("Deseja jogar novamente? (1 para sim, qualquer tecla para não)");
                Console.Write("Opção: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta != 1)
                {
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

    public static void PvPC()
    {
        char[,] tabuleiro = new char[3, 3];
        int contadorJogo = 0, resposta;
        bool fimDeJogo = false;

        do
        {
            if (contadorJogo == 0) //Inicializando o tabuleiro
            {
                inicializarTabuleiro(tabuleiro);
            }

            realizarJogadaPc(tabuleiro); //Realizando a jogada do Computador
            contadorJogo++;

            printTabuleiro(tabuleiro);

            fimDeJogo = verificaGanhadorPvPC(tabuleiro, contadorJogo, false); //Verificando se alguém ganhou



            if (!fimDeJogo)
            {
                realizarJogadaP(tabuleiro); //Realizando a jogada do Jogador
                contadorJogo++;

                printTabuleiro(tabuleiro);

                fimDeJogo = verificaGanhadorPvPC(tabuleiro, contadorJogo, false);
            }

            if (fimDeJogo) //Checando se o usuário deseja jogar novamente
            {
                Console.WriteLine("Deseja jogar novamente? (1 para sim, qualquer tecla para não)");
                Console.Write("Opção: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta != 1)
                {
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

    static void realizarJogada(char[,] tabuleiro, int contadorJogada)
    {
        int jogada, contador = 0;
        bool jogadaValida = false;
        char simbolo;

        if (contadorJogada == 1)
        {
            simbolo = 'X';
        }
        else
        {
            simbolo = 'O';
        }

        do
        {
            Console.WriteLine($"\n{contadorJogada}º Jogador ({simbolo}) em que posição deseja jogar: ");
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
                            contador = 0;
                        }
                        else
                        {
                            if (contadorJogada == 1)
                            {
                                tabuleiro[i, j] = 'X';
                                jogadaValida = true;
                                break;
                            }
                            else
                            {
                                tabuleiro[i, j] = 'O';
                                jogadaValida = true;
                                break;
                            }
                        }
                    }
                }
            }
        } while (!jogadaValida);
    }

    static void realizarJogadaP(char[,] tabuleiro)
    {
        int jogada, contador = 0;
        bool jogadaValida = false;

        do
        {
            Console.WriteLine($"\nTurno do Jogador (X)\nEm que posição deseja jogar: ");
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
                            contador = 0;
                        }
                        else
                        {
                            tabuleiro[i, j] = 'X';
                            jogadaValida = true;
                            break;
                        }
                    }
                }
            }
        } while (!jogadaValida);
    }

    static void realizarJogadaPc(char[,] tabuleiro)
    {
        int jogadaPC, contador = 0;
        bool jogadaValida = false;
        Random randomint = new Random();

        do
        {
            jogadaPC = randomint.Next(0, 10);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    contador++;
                    if (contador == jogadaPC)
                    {
                        if (tabuleiro[i, j] != ' ')
                        {
                            jogadaValida = false;
                            contador = 0;
                        }
                        else
                        {
                            tabuleiro[i, j] = 'O';
                            jogadaValida = true;
                            break;
                        }
                    }
                }
            }
        } while (!jogadaValida);

        Console.WriteLine("\nTurno do Computador (O)\n");
    }

    static bool verificaGanhadorPvP(char[,] tabuleiro, int contadorJogo, bool fimDeJogo)
    {
        fimDeJogo = verificaLinhasPvP(tabuleiro, false); //Verificando se alguem ganhou nas linhas

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaColunasPvP(tabuleiro, false); //Verificando se alguem ganhou nas colunas
        }

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaDiagonalPrincipalPvP(tabuleiro, false); //Verificando se alguem ganhou na diagonal principal
        }

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaDiagonalInversaPvP(tabuleiro, false); //Verificando se alguem ganhou na diagonal inversa
        }

        if (contadorJogo == 9)
        {
            Console.WriteLine("--- Deu velha! ---");
            fimDeJogo = true;
        }

        return fimDeJogo;
    }

    static bool verificaGanhadorPvPC(char[,] tabuleiro, int contadorJogo, bool fimDeJogo)
    {
        fimDeJogo = verificaLinhasPvPC(tabuleiro, false); //Verificando se alguem ganhou nas linhas

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaColunasPvPC(tabuleiro, false); //Verificando se alguem ganhou nas colunas
        }

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaDiagonalPrincipalPvPC(tabuleiro, false); //Verificando se alguem ganhou na diagonal principal
        }

        if (fimDeJogo == false)
        {
            fimDeJogo = verificaDiagonalInversaPvPC(tabuleiro, false); //Verificando se alguem ganhou na diagonal inversa
        }

        if (contadorJogo == 9)
        {
            Console.WriteLine("--- Deu velha! ---");
            fimDeJogo = true;
        }

        return fimDeJogo;
    }

    static bool verificaLinhasPvP(char[,] tabuleiro, bool fimDeJogo)
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

    static bool verificaColunasPvP(char[,] tabuleiro, bool fimDeJogo)
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

    static bool verificaDiagonalPrincipalPvP(char[,] tabuleiro, bool fimDeJogo)
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

    static bool verificaDiagonalInversaPvP(char[,] tabuleiro, bool fimDeJogo)
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

    static bool verificaLinhasPvPC(char[,] tabuleiro, bool fimDeJogo)
    {
        for (int i = 0; i < 3; i++)
        {
            int contadorJ = 0;
            int contadorPC = 0;
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == 'X')
                {
                    contadorJ++;
                }
                else if (tabuleiro[i, j] == 'O')
                {
                    contadorPC++;
                }
            }
            if (contadorJ == 3)
            {
                Console.WriteLine("--- Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorPC == 3)
            {
                Console.WriteLine("--- Computador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }

    static bool verificaColunasPvPC(char[,] tabuleiro, bool fimDeJogo)
    {
        for (int i = 0; i < 3; i++)
        {
            int contadorJ = 0;
            int contadorPC = 0;
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[j, i] == 'X')
                {
                    contadorJ++;
                }
                else if (tabuleiro[j, i] == 'O')
                {
                    contadorPC++;
                }
            }
            if (contadorJ == 3)
            {
                Console.WriteLine("--- Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorPC == 3)
            {
                Console.WriteLine("--- Computador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }

    static bool verificaDiagonalPrincipalPvPC(char[,] tabuleiro, bool fimDeJogo)
    {
        int contadorJ = 0;
        int contadorPC = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        contadorJ++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        contadorPC++;
                    }
                }
            }
            if (contadorJ == 3)
            {
                Console.WriteLine("--- Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorPC == 3)
            {
                Console.WriteLine("--- Computador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }

    static bool verificaDiagonalInversaPvPC(char[,] tabuleiro, bool fimDeJogo)
    {
        int contadorJ = 0;
        int contadorPC = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i + j == 2)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        contadorJ++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        contadorPC++;
                    }
                }
            }
            if (contadorJ == 3)
            {
                Console.WriteLine("--- Jogador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
            else if (contadorPC == 3)
            {
                Console.WriteLine("--- Computador foi o vencedor! ---");
                fimDeJogo = true;
                break;
            }
        }

        return fimDeJogo;
    }
}