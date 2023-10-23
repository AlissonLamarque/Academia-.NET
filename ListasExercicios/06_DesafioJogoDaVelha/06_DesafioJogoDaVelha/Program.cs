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
        int fimDeJogo = 0;

        do
        {
            if (contadorJogo == 0) //Inicializando o tabuleiro
            {
                inicializarTabuleiro(tabuleiro);
            }

            realizarJogada(tabuleiro, 1); //Realizando a jogada do 1º Jogador
            contadorJogo++;

            printTabuleiro(tabuleiro);

            fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, fimDeJogo); //Verificando se alguém ganhou
            declararVitoria(fimDeJogo, 0);

            if (fimDeJogo == 0)
            {
                realizarJogada(tabuleiro, 2); //Realizando a jogada do 2º Jogador
                contadorJogo++;

                printTabuleiro(tabuleiro);

                fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, fimDeJogo);
                declararVitoria(fimDeJogo, 0);
            }

            if (fimDeJogo != 0) //Checando se o usuário deseja jogar novamente
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
                    fimDeJogo = 0;
                }
            }

        } while (true);
    }

    public static void PvPC()
    {
        char[,] tabuleiro = new char[3, 3];
        int contadorJogo = 0, resposta;
        int fimDeJogo = 0;

        do
        {
            if (contadorJogo == 0) //Inicializando o tabuleiro
            {
                inicializarTabuleiro(tabuleiro);
            }

            realizarJogadaP(tabuleiro); //Realizando a jogada do Computador
            contadorJogo++;

            printTabuleiro(tabuleiro);

            fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, fimDeJogo); //Verificando se alguém ganhou
            declararVitoria(fimDeJogo, 1);

            if (fimDeJogo == 0)
            {
                realizarJogadaPC(tabuleiro); //Realizando a jogada do Jogador
                contadorJogo++;

                printTabuleiro(tabuleiro);

                fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, fimDeJogo);
                declararVitoria(fimDeJogo, 1);
            }

            if (fimDeJogo != 0) //Checando se o usuário deseja jogar novamente
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
                    fimDeJogo = 0;
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
        char simbolo = (contadorJogada % 2 == 1) ? 'X' : 'O';
        int jogada = 0, linha, coluna;
        bool jogadaValida = false;

        while (!jogadaValida)
        {
            Console.WriteLine($"\n{contadorJogada}º Jogador ({simbolo}) em que posição deseja jogar (1-9): ");
            jogada = int.Parse(Console.ReadLine());

            if (jogada >= 1 && jogada <= 9)
            {
                linha = (jogada - 1) / 3;
                coluna = (jogada - 1) % 3;

                if (tabuleiro[linha, coluna] == ' ')
                {
                    tabuleiro[linha, coluna] = simbolo;
                    jogadaValida = true;
                }
                else
                {
                    Console.WriteLine("Posição preenchida! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Tente novamente (1-9).");
            }
        }
    }

    static void realizarJogadaP(char[,] tabuleiro)
    {
        int jogada = 0, linha, coluna;
        bool jogadaValida = false;

        while (!jogadaValida)
        {
            Console.WriteLine($"\nTurno do Jogador (X)\nEm que posição deseja jogar: ");
            jogada = int.Parse(Console.ReadLine());

            if (jogada >= 1 && jogada <= 9)
            {
                linha = (jogada - 1) / 3;
                coluna = (jogada - 1) % 3;

                if (tabuleiro[linha, coluna] == ' ')
                {
                    tabuleiro[linha, coluna] = 'X';
                    jogadaValida = true;
                }
                else
                {
                    Console.WriteLine("Posição preenchida! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Tente novamente (1-9).");
            }
        }
    }

    static void realizarJogadaPC(char[,] tabuleiro)
    {
        bool jogada = false;

        if (!jogada)
        {
            for (int i = 0; i < 3; i++)
            {
                int contador1 = 0, contador2 = 0;

                if (!jogada)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[i, j] == 'X')
                        {
                            contador1++;
                        }
                        else if (tabuleiro[i, j] == 'O')
                        {
                            contador2++;
                        }
                        if (contador2 == 2)
                        {
                            if (!jogada)
                            {
                                for (int x = 0; x < 3; x++)
                                {
                                    if (tabuleiro[i, x] == ' ')
                                    {
                                        tabuleiro[i, x] = 'O';
                                        jogada = true;
                                        Console.WriteLine($"\nTurno do Computador (O)\nEle jogou na posição {tabuleiro[i, j]}");
                                    }
                                }
                            }
                        }
                        else if (contador1 == 2)
                        {
                            if (!jogada)
                            {
                                for (int x = 0; x < 3; x++)
                                {
                                    if (tabuleiro[i, x] == ' ')
                                    {
                                        tabuleiro[i, x] = 'O';
                                        jogada = true;
                                        Console.WriteLine($"\nTurno do Computador (O)\nEle jogou na posição {tabuleiro[i, j]}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        } //Verificando as linhas
        if (!jogada)
        {
            for (int i = 0; i < 3; i++)
            {
                int contador1 = 0, contador2 = 0;

                if (!jogada)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[j, i] == 'X')
                        {
                            contador1++;
                        }
                        else if(tabuleiro[j, i] == 'O')
                        {
                            contador2++;
                        }
                        if (contador2 == 2)
                        {
                            if (!jogada)
                            {
                                for (int x = 0; x < 3; x++)
                                {
                                    if (tabuleiro[x, i] == ' ')
                                    {
                                        tabuleiro[x, i] = 'O';
                                        jogada = true;
                                        Console.WriteLine($"\nTurno do Computador (O)\nEle jogou na posição {tabuleiro[i, j]}");
                                    }
                                }
                            }
                        }
                        else if(contador1 == 2)
                        {
                            if (!jogada)
                            {
                                for (int x = 0; x < 3; x++)
                                {
                                    if (tabuleiro[x, i] == ' ')
                                    {
                                        tabuleiro[x, i] = 'O';
                                        jogada = true;
                                        Console.WriteLine($"\nTurno do Computador (O)\nEle jogou na posição {tabuleiro[i, j]}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        } //Verificando as colunas
        if (!jogada)
        {
            for (int i = 0; i <= 2; i += 2)
            {
                if (!jogada)
                {
                    for (int j = 0; j <= 2; j += 2)
                    {
                        if (!jogada)
                        {
                            if (tabuleiro[i, j] == ' ')
                            {
                                tabuleiro[i, j] = 'O';
                                jogada = true;
                                Console.WriteLine($"\nTurno do Computador (O)\nEle jogou na posição {tabuleiro[i, j]}");
                            }
                        }
                    }
                }
            }
        } //Caso outros if's não se realizem joga em uma das extremidades
        if (!jogada)
        {
            for (int i = 0; i < 3; i++)
            {
                if (!jogada)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (!jogada)
                        {
                            if (tabuleiro[i, j] == ' ')
                            {
                                tabuleiro[i, j] = 'O';
                                jogada = true;
                                Console.WriteLine($"\nTurno do Computador (O)\nEle jogou na posição {tabuleiro[i, j]}");
                            }
                        }
                    }
                }
            }
        } //Caso nenhum dos if's se realize o PC jogara na primeira posição válida que encontrar
    }

    static void declararVitoria(int fimDeJogo, int modoDeJogo)
    {
        if (modoDeJogo == 0)
        {
            if (fimDeJogo == 1)
            {
                Console.WriteLine("--- 1º Jogador foi o vencedor! ---");
            }
            else if (fimDeJogo == 2)
            {
                Console.WriteLine("--- 2º Jogador foi o vencedor! ---");
            }
            else if (fimDeJogo == 3)
            {
                Console.WriteLine("--- Deu velha! ---");
            }
        }
        else
        {
            if (fimDeJogo == 1)
            {
                Console.WriteLine("--- Jogador foi o vencedor! ---");
            }
            else if (fimDeJogo == 2)
            {
                Console.WriteLine("--- Computador foi o vencedor! ---");
            }
            else if (fimDeJogo == 3)
            {
                Console.WriteLine("--- Deu velha! ---");
            }
        }
    }

    static int verificaGanhador(char[,] tabuleiro, int contadorJogo, int fimDeJogo)
    {
        fimDeJogo = verificaLinhas(tabuleiro, fimDeJogo); //Verificando se alguem ganhou nas linhas

        if (fimDeJogo == 0)
        {
            fimDeJogo = verificaColunas(tabuleiro, fimDeJogo); //Verificando se alguem ganhou nas colunas
        }

        if (fimDeJogo == 0)
        {
            fimDeJogo = verificaDiagonalPrincipal(tabuleiro, fimDeJogo); //Verificando se alguem ganhou na diagonal principal
        }

        if (fimDeJogo == 0)
        {
            fimDeJogo = verificaDiagonalInversa(tabuleiro, fimDeJogo); //Verificando se alguem ganhou na diagonal inversa
        }

        if (fimDeJogo == 0 && contadorJogo == 9)
        {
            fimDeJogo = 3;
        }

        return fimDeJogo;
    }

    static int verificaLinhas(char[,] tabuleiro, int fimDeJogo)
    {
        for (int i = 0; i < 3; i++)
        {
            int contador1 = 0, contador2 = 0;

            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == 'X')
                {
                    contador1++;
                }
                else if (tabuleiro[i, j] == 'O')
                {
                    contador2++;
                }
            }
            if (contador1 == 3)
            {
                fimDeJogo = 1;
                break;
            }
            else if (contador2 == 3)
            {
                fimDeJogo = 2;
                break;
            }
        }

        return fimDeJogo;
    }

    static int verificaColunas(char[,] tabuleiro, int fimDeJogo)
    {
        for (int i = 0; i < 3; i++)
        {
            int contador1 = 0;
            int contador2 = 0;
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[j, i] == 'X')
                {
                    contador1++;
                }
                else if (tabuleiro[j, i] == 'O')
                {
                    contador2++;
                }
            }
            if (contador1 == 3)
            {
                fimDeJogo = 1;
                break;
            }
            else if (contador2 == 3)
            {
                fimDeJogo = 2;
                break;
            }
        }

        return fimDeJogo;
    }

    static int verificaDiagonalPrincipal(char[,] tabuleiro, int fimDeJogo)
    {
        int contador1 = 0;
        int contador2 = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        contador1++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        contador2++;
                    }
                }
            }
            if (contador1 == 3)
            {
                fimDeJogo = 1;
                break;
            }
            else if (contador2 == 3)
            {
                fimDeJogo = 2;
                break;
            }
        }

        return fimDeJogo;
    }

    static int verificaDiagonalInversa(char[,] tabuleiro, int fimDeJogo)
    {
        int contador1 = 0;
        int contador2 = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i + j == 2)
                {
                    if (tabuleiro[j, i] == 'X')
                    {
                        contador1++;
                    }
                    else if (tabuleiro[j, i] == 'O')
                    {
                        contador2++;
                    }
                }
            }
            if (contador1 == 3)
            {
                fimDeJogo = 1;
                break;
            }
            else if (contador2 == 3)
            {
                fimDeJogo = 2;
                break;
            }
        }

        return fimDeJogo;
    }
}