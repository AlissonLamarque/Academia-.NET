// 5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada
// como parâmetro e retorna a soma dos elementos na diagonal principal.

public class Exercicio05
{
    public static void Main()
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int soma;

        soma = SomaDiagonalPrincipal(matriz);

        Console.WriteLine($"A soma da diagonal principal é igual a {soma}");
    }

    public static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    soma += matriz[i, j];
                }
            }
        }

        return soma;
    }
}