// 4. Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de
// mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

public class Exercicio04
{
    public static void Main()
    {
        int[] v1 = new int[10];
        int[] v2 = new int[10];
        int[] v3 = new int[10];

        for (int i = 0; i < v1.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}º posição do 1º vetor: ");
            v1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < v2.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}º posição do 2º vetor: ");
            v2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < v3.Length; i++)
        {
            v3[i] = v1[i] * v2[i];
        }

        for (int i = 0; i < v3.Length; i++)
        {
            Console.Write($" {v3[i]} ");
        }
    }
}

