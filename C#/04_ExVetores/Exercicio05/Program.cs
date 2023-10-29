// 5. Escreva um algoritmo que leia um vetor de 80 elementos inteiros.
// Encontre e mostre o menor elemento e a sua posição.

public class Exercicio05
{
    public static void Main()
    {
        int[] vetor = new int[80];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int menor = vetor[0];
        int indice = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (menor > vetor[i])
            {
                menor = vetor[i];
                indice = i;
            }
        }

        Console.WriteLine($"O menor valor presente no vetor é {menor} com índice {indice}");
    }
}