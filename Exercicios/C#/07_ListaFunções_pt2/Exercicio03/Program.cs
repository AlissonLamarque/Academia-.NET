// 3 - Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.

public class Exercicio03
{
    public static void Main()
    {
        int[,] matriz = {{1, 2, 3},{4, 5, 6},{7, 8, 9}};
        int[,] matrizT = new int[3, 3];
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {matriz[i, j]} |");
            }
        }
        
        matriz = TransporMatriz(matriz, matrizT);

        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($" {matrizT[i, j]} |");
            }
        }
    }

    public static int[,] TransporMatriz(int[,] matriz, int[,] matrizT)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matrizT[i, j] = matriz[j, i];
            }
        }

        return matrizT;
    }
}