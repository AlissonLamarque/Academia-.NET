// 5) Leia duas matrizes 2x3 de números double. 
// Imprima a soma destas duas matrizes.

public class Exercicio05
{
    public static void Main()
    {
        double[,] matriz1 = new double[2, 3];
        double[,] matriz2 = new double[2, 3];

        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para 1ª matriz: ");
                matriz1[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para 2ª matriz: ");
                matriz2[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine();
            for (int j = 0;j < 3; j++)
            {
                Console.Write($"{matriz1[i, j] + matriz2[i, j]} |");
            }
        }
    }
}