// 11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz
// resultante da divisão dos elementos da matriz A pela soma dos seus indices.

public class Exercicio11
{
    public static void Main()
    {
        double[,] A = new double[3, 3];
        double[,] B = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para a matriz: ");
                A[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                B[i, j] = A[i, j] / (i + j);
                Console.Write($"{B[i, j]:F1} | ");
            }
        }
    }
}