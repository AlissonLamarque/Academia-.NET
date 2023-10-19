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

class DesafioJogoDaVelhaPvP
{
    public static void Main()
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

            fimDeJogo = verificaGanhador(tabuleiro, contadorJogo, false); //Verificando se alguém ganhou
            


            if (!fimDeJogo)
            {
                realizarJogada(tabuleiro, 2); //Realizando a jogada do 2º Jogador
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
    
    static bool verificaGanhadorPvP(char[,] tabuleiro, int contadorJogo, bool fimDeJogo)
    {
        fimDeJogo = verificaLinhasPvP(tabuleiro, false); //Verificando se alguem ganhou nas linhas

        if (!fimDeJogo)
        {
            fimDeJogo = verificaColunasPvP(tabuleiro, false); //Verificando se alguem ganhou nas colunas
        }

        if (!fimDeJogo)
        {
            fimDeJogo = verificaDiagonalPrincipalPvP(tabuleiro, false); //Verificando se alguem ganhou na diagonal principal
        }

        if (!fimDeJogo)
        {
            fimDeJogo = verificaDiagonalInversaPvP(tabuleiro, false); //Verificando se alguem ganhou na diagonal inversa
        }

        if (!fimDeJogo && contadorJogo == 9){
            Console.WriteLine("--- Deu velha! ---");
            fimDeJogo = true;
        }

        return fimDeJogo;
    }

    static bool verificaGanhadorPvPC(char[,] tabuleiro, int contadorJogo, bool fimDeJogo)
    {
        fimDeJogo = verificaLinhasPvPC(tabuleiro, false); //Verificando se alguem ganhou nas linhas

        if (!fimDeJogo)
        {
            fimDeJogo = verificaColunasPvPC(tabuleiro, false); //Verificando se alguem ganhou nas colunas
        }

        if (!fimDeJogo)
        {
            fimDeJogo = verificaDiagonalPrincipalPvPC(tabuleiro, false); //Verificando se alguem ganhou na diagonal principal
        }

        if (!fimDeJogo)
        {
            fimDeJogo = verificaDiagonalInversaPvPC(tabuleiro, false); //Verificando se alguem ganhou na diagonal inversa
        }

        if (!fimDeJogo && contadorJogo == 9)
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
}