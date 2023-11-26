// 4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes
// como parâmetros e retorna a matriz resultante da multiplicação.

public class Exercicio04
{
    public static void Main()
    {
        int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matriz2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matriz3 = new int[3, 3];

        matriz3 = MultiplicarMatrizes(matriz1, matriz2);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {matriz3[i, j]} |");
            }
        }
    }

    public static int[,] MultiplicarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int[,] matriz3 = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz3[i, j] = matriz1[i, j] * matriz2[i, j];
            }
        }

        return matriz3;
    }
}