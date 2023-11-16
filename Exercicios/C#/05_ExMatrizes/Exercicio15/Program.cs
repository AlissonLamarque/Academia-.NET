// 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

public class Exercicio15
{
    public static void Main()
    {
        int[,] A = new int[4, 4];
        int[,] B = new int[4, 4];
        int[,] C = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Valor para matriz A: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Valor para matriz B: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
                Console.Write($"{C[i, j]} | ");
            }
        }
    }
}