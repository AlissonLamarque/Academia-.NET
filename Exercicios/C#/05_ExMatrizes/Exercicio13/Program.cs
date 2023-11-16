/*
13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e 
verifique se a soma dos elementos da diagonal principal é igual a soma 
dos elementos da diagonal secundária.
 */

public class Exercicio13
{
    public static void Main()
    {
        int[,] matriz = new int[5, 5];
        int somaP = 0, somaS = 0;
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Valor para matriz: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == j)
                    somaP += matriz[i, j];

                if (i + j == 4)
                    somaS += matriz[i, j];
            }
        }

        if (somaP == somaS)
            Console.WriteLine("A soma da diagonal principal e secundária são iguais");
        else
            Console.WriteLine("A soma da diagonal principal e secundária são diferentes");
    }
}