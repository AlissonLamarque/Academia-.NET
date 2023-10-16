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

class DesafioJogoDaVelha
{
    public static void Main(string[] args)
    {
        char[,] tabuleiro = new char[3, 3];
        string[] vetorJogada = new string[2];
        string jogada;
        int jogadaLinha, jogadaColuna, contadorJ1, contadorJ2, contadorJogo = 0, resposta;
        bool fimDeJogo = false;

        do
        {
            if (contadorJogo == 0) //Inicializando o tabuleiro
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
                Console.WriteLine($" {tabuleiro[0,0]} | {tabuleiro[0,1]} | {tabuleiro[0,2]} ");
                Console.WriteLine("---|---|---");
                Console.WriteLine($" {tabuleiro[1,0]} | {tabuleiro[1,1]} | {tabuleiro[1,2]} ");
                Console.WriteLine("---|---|---");
                Console.WriteLine($" {tabuleiro[2,0]} | {tabuleiro[2,1]} | {tabuleiro[2,2]} ");
            }


            while (true) //Recebendo a jogada do 1º jogador
            {
                Console.WriteLine("\n1º Jogador (X) em que posição deseja jogar: ");
                jogada = Console.ReadLine();

                vetorJogada = jogada.Split(',');
                jogadaLinha = int.Parse(vetorJogada[0]);
                jogadaColuna = int.Parse(vetorJogada[1]);

                if (tabuleiro[jogadaLinha, jogadaColuna] != ' ')
                {
                    Console.WriteLine("Posição preenchida! Tente novamente.");
                }
                else
                {
                    tabuleiro[jogadaLinha, jogadaColuna] = 'X';
                    break;
                }
            }

            Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]} ");

            while(true) //Recebendo a jogada do 2º jogador
            {
                Console.WriteLine("\n2º Jogador (O) em que posição deseja jogar: ");
                jogada = Console.ReadLine();

                vetorJogada = jogada.Split(',');
                jogadaLinha = int.Parse(vetorJogada[0]);
                jogadaColuna = int.Parse(vetorJogada[1]);

                if (tabuleiro[jogadaLinha, jogadaColuna] != ' ')
                {
                    Console.WriteLine("Posição preenchida! Tente novamente.");
                }
                else
                {
                    tabuleiro[jogadaLinha, jogadaColuna] = 'O';
                    break;
                }
            }

            Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]} ");

            for (int i = 0; i < 3; i++) //Verificando se alguem ganhou nas linhas
            {
                contadorJ1 = 0;
                contadorJ2 = 0;
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

            if (fimDeJogo == false) //Verificando se alguem ganhou nas colunas
            {
                for (int i = 0; i < 3; i++)
                {
                    contadorJ1 = 0;
                    contadorJ2 = 0;
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
            }

            if (fimDeJogo == false) //Verificando se alguem ganhou na diagonal principal
            {
                contadorJ1 = 0;
                contadorJ2 = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if(i == j)
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
            }

            if (fimDeJogo == false) //Verificando se alguem ganhou na diagonal inversa
            {
                contadorJ1 = 0;
                contadorJ2 = 0;

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
            }

            contadorJogo++;

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
                    contadorJ1 = 0;
                    contadorJ2 = 0;
                    fimDeJogo = false;
                }
            }

        } while (true);
    }
}