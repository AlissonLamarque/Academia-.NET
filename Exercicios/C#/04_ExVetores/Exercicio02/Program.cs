// 2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então
// realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

public class Exercicio02
{
    public static void Main()
    {
        int[] v1 = new int[20];
        int[] v2 = new int[20];
        int[] v3 = new int[20];

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
            v3[i] = v1[i] + v2[i];
        }

        for (int i = 0; i < v3.Length; i++)
        {
            Console.Write($" {v3[i]} ");
        }
    }
}
