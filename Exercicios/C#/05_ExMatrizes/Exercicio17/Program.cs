/*
17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o 
elemento minimax, ou seja,o menor elemento da linha onde se encontra o maior elemento 
da matriz. Escreva também a linha e a coluna onde foi encontrado.
 */

public class Exercicio17
{
    public static void Main()
    {
        int[,] matriz = new int[10, 10];
        Random random = new Random();
        int maiorValor = 0, menorValor = 0, linhaMaiorValor = 0, colunaMenorValor = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = random.Next(1, 100);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == 0 && j == 0)
                {
                    maiorValor = matriz[i, j];
                    linhaMaiorValor = i;
                }

                else
                {
                    if (matriz[i, j] > maiorValor)
                        maiorValor = matriz[i, j];
                        linhaMaiorValor = i;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 0)
                menorValor = matriz[linhaMaiorValor, i];
            else
            {
                if (menorValor > matriz[linhaMaiorValor, i])
                {
                    menorValor = matriz[linhaMaiorValor, i];
                    colunaMenorValor = i;
                }
            }
        }

        Console.WriteLine($"Maior elemento: {maiorValor}\nMenor elemento da linha do maior elemento: {menorValor}\nLinha: {linhaMaiorValor + 1}\nColuna: {colunaMenorValor + 1}");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{matriz[i, j]} | ");
            }
        }
    }
}