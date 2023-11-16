/*
6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
Random random = new Random();
int randomNumber = random.Next(0, 100);
 */

public class Exercicio06
{
    public static void Main()
    {
        int[,] matriz = new int[4, 4];
        Random random = new Random();
        int maiorValor = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = random.Next(0, 10);
            }
        }

        for (int i = 0;i < 4; i++)
        {
            for (int j = 0;j < 4; j++)
            {
                if (i == 0 && j == 0)
                    maiorValor = matriz[i, j];
                else
                {
                    if (matriz[i, j] > maiorValor)
                        maiorValor = matriz[i, j];
                }
            }
        }

        Console.WriteLine($"Maior valor da matriz: {maiorValor}");
    }
}