// 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
// Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

public class Exercicio16
{
    public static void Main()
    {
        int[,] matriz1 = new int[3, 4];
        int[,] matriz2 = new int[4, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Valor para matriz: ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz2[j, i] = matriz1[i, j];
            }
        }

        Console.WriteLine("Matriz 1");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{matriz1[i, j]} | ");
            }
        }

        Console.WriteLine("\n");

        Console.WriteLine("Matriz 2");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matriz2[i, j]} | ");
            }
        }
    }
}