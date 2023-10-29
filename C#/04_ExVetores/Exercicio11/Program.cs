// 11. Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos
// do vetor e após escrever os elementos na ordem inversa.

public class Exercicio11
{
    public static void Main()
    {
        int[] vetor = new int[5];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length ; i++)
        {
            Console.Write($" |{vetor[i]}| ");
        }

        Console.WriteLine("");

        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write($" |{vetor[i]}| ");
        }
    }
}

