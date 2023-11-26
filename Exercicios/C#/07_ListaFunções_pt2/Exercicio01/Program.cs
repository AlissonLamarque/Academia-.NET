//1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da
//linha em que se encontra o maior elemento da matriz. Escreva um programa que lê uma matriz
//[10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.

public class Exercicio01
{
    public static void Main()
    {
        int[,] matriz = new int[10,10];
        int maiorValor = 0, linhaMaiorValor = 0, minimax = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine($"Digite um valor para a posição {matriz[i,j]} da matriz: ");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == 0 & j == 0)
                {
                    maiorValor = matriz[i,j];
                    linhaMaiorValor = i;
                }
                else
                {
                    if (matriz[i,j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                        linhaMaiorValor = i;
                    }
                }
            }
        }

        for (int i = 0; i < matriz.GetLength(1); i++)
        {
            if (i == 0)
            {
                minimax = matriz[linhaMaiorValor,i];
            }
            else
            {
                if (minimax > matriz[linhaMaiorValor, i])
                {
                    minimax = matriz[linhaMaiorValor, i];
                }
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write( $" {matriz[i, j]} |");
            }
        }

        Console.WriteLine($"\nMaior valor: {maiorValor}\nLinha do maior valor: {linhaMaiorValor}\nElemento minimax: {minimax}");
    }
}
