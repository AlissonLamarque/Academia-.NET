/*
14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os 
elementos da diagonal principal (da esquerda para a direita) são os 
mesmos da diagonal secundária (direita pra esquerda).
 */

public class Exercicio14
{
    public static void Main()
    {
        int[,] matriz = new int[5, 5];
        int[] diagP = new int[5], diagS = new int[5];
        int contP = 0, contS = 0;
        bool valorIgual = true;

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
                {
                    diagP[contP] = matriz[i, j];
                    contP++;
                }

                if (i + j == 4)
                {
                    diagS[contS] = matriz[i, j];
                    contS++;
                }
            }
        }

        for (int i = 0;i < 5; i++)
        {
            if (diagP[i] != diagS[i])
            {
                valorIgual = false;
                break;
            }
        }

        if (valorIgual)
            Console.WriteLine("Os elementos da diagonal principal e secundária são iguais");
        else
            Console.WriteLine("Os elementos da diagonal principal e secundária são diferentes");
    }
}