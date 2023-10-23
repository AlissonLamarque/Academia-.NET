//1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da
//linha em que se encontra o maior elemento da matriz. Escreva um programa que lê uma matriz
//[10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.

public class Exercicio01
{
    public static void Main()
    {
        int[,] matriz = new int[3,3];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine($"Digite um valor para a posição {matriz[i,j]} da matriz: ");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }
    }
}
