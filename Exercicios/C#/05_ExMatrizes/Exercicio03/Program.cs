// 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

public class Exercicio03
{
    public static void Main()
    {
        int[,] matriz = new int[4,4];
        int cont = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                cont++;
                matriz[i, j] = cont;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0;j < 4; j++)
            {
                if (i == j)
                    Console.Write($"{matriz[i, j]} - ");
            }
        }
    }
}