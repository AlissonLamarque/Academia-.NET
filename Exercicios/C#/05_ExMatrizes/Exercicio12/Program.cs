// 12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida
// mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

public class Exercicio12
{
    public static void Main()
    {
        int[,] matriz = new int[4, 3];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para matriz: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((i + j) % 2 == 0)
                    Console.Write($"{matriz[i, j]} - ");
            }
        }
    }
}