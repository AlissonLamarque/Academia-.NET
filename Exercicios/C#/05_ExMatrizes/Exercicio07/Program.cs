// 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C,
// onde cada elemento de C é a subtração do elemento correspondente de A com B.

public class Exercicio07
{
    public static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para 1ª matriz: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para 2ª matriz: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                C[i, j] = A[i, j] - B[i, j];
                Console.Write($"{C[i, j]} |");
            }
        }
    }
}