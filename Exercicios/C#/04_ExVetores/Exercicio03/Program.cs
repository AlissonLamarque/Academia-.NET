// 3. Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o
// índice da posição dos valores correspondentes a números primos.

public class Exercicio03
{
    public static void Main()
    {
        int[] vetor = new int[20];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] <= 1){}
            else
            {
                if (vetor[i] == 2 || vetor[i] == 3 || vetor[i] == 5 || vetor[i] == 7)
                {
                    Console.WriteLine($"    [{i}]");
                }
                else
                {
                    if (vetor[i] % 2 == 0 || vetor[i] % 3 == 0 || vetor[i] % 5 == 0 || vetor[i] % 7 == 0){}
                    else
                    {
                        Console.WriteLine($"    [{i}]");
                    }
                }
            }
        }
    }
}