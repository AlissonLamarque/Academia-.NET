// 15. Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor,
// e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento
// do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos
// do primeiro vetor em uma linha e os do segundo uma linha abaixo.

public class Exercicio15
{
    public static void Main()
    {
        int[] vetor1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int[] vetor2 = new int[20];
        int auxiliar = 0;

        for (int i = vetor1.Length -1; i > -1; i--)
        {
            vetor2[auxiliar] = vetor1[i];
            auxiliar++;
        }

        for (int i = 0; i < vetor1.Length; i++)
        {
            Console.Write($"{vetor1[i]} - ");
        }
        Console.WriteLine("");
        for (int i = 0; i < vetor2.Length; i++)
        {
            Console.Write($"{vetor2[i]} - ");
        }
    }
}