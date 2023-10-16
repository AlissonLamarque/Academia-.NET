using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;
    static int choice;
    static int flag = 0;
    static bool gameOver = false;

    static void Main()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Jogador 1: X e Jogador 2: O");
            Console.WriteLine("\n");
            PrintBoard();

            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine($"\nTurno do Jogador {currentPlayer}");
                Console.Write("Escolha uma posição (1-9): ");
                try
                {
                    choice = int.Parse(Console.ReadLine());

                    if (choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Escolha inválida. Por favor, escolha uma posição disponível.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Escolha inválida. Por favor, escolha uma posição disponível.");
                }
            }

            if (currentPlayer % 2 == 0)
            {
                board[choice - 1] = 'O';
            }
            else
            {
                board[choice - 1] = 'X';
            }

            Console.Clear();
            PrintBoard();
            flag = CheckWin();
            currentPlayer++;
        }
        while (flag != 1 && flag != -1);

        if (flag == 1)
        {
            Console.WriteLine($"Jogador {currentPlayer % 2} venceu!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }

        Console.Write("Deseja jogar novamente? (S para sim, qualquer outra tecla para sair): ");
        if (Console.ReadLine().ToUpper() == "S")
        {
            ResetGame();
        }
        else
        {
            Console.WriteLine("Obrigado por jogar!");
            gameOver = true;
        }
    }

    private static void PrintBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    private static int CheckWin()
    {
        // Verificar linhas, colunas e diagonais para vitória.
        for (int i = 0; i < 8; i++)
        {
            int a = 0, b = 0;
            switch (i)
            {
                case 0:
                    a = 0;
                    b = 1;
                    break;
                case 1:
                    a = 1;
                    b = 2;
                    break;
                case 2:
                    a = 0;
                    b = 3;
                    break;
                case 3:
                    a = 3;
                    b = 6;
                    break;
                case 4:
                    a = 0;
                    b = 4;
                    break;
                case 5:
                    a = 2;
                    b = 4;
                    break;
                case 6:
                    a = 0;
                    b = 5;
                    break;
                case 7:
                    a = 2;
                    b = 3;
                    break;
            }

            if (board[a] == board[b] && board[b] == board[a + b])
            {
                return 1;
            }
        }

        // Verificar empate
        for (int i = 0; i < 9; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                return -1;
            }
        }

        return 0;
    }

    private static void ResetGame()
    {
        board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        currentPlayer = 1;
        flag = 0;
        gameOver = false;
        Main();
    }
}
