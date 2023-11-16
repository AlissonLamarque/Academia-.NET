// 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos,
// em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

public class Exercicio10
{
    public static void Main()
    {
        int[,] A = new int[4, 4];
        int[,] B = new int[4, 4];
        int somaA = 0, somaB = 0, mediaA, mediaB, contAcMediaA = 0, contAbMediaB = 0, contAcMediaB = 0, contAbMediaA = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para 1ª matriz: ");
                A[i, j] = int.Parse(Console.ReadLine());
                somaA += A[i, j];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para 2ª matriz: ");
                B[i, j] = int.Parse(Console.ReadLine());
                somaB += B[i, j];
            }
        }

        mediaA = somaA / 9;
        mediaB = somaB / 9;

        for (int i = 0;i < 3; i++)
        {
            for (int j = 0;j < 3; j++)
            {
                if (A[i, j] >= mediaA)
                    contAcMediaA++;
                else
                    contAbMediaA++;
                if (B[i, j] >= mediaB)
                    contAcMediaB++;
                else
                    contAbMediaB++;
            }
        }

        Console.WriteLine($"Matriz A\nMédia: {mediaA}\nElementos acima da média: {contAcMediaA}\nElementos abaixo da média: {contAbMediaA}");
        Console.WriteLine($"Matriz B\nMédia: {mediaB}\nElementos acima da média: {contAcMediaB}\nElementos abaixo da média: {contAbMediaB}");
    }
}