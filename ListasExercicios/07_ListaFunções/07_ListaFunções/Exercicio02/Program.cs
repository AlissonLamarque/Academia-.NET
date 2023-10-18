// 2) Fazer programa que tenha duas funções. i) para ler um vetor de 10 elementos (variável global) e ii) para verificar e apresentar a quantidadede elementos pares que este vetor possui.

public class Exercicio02
{

    public static void Main()
    {
        int[] vetor = new int[10];

        lerVetor(vetor);
        qtdNumPares(vetor);
    }

    static void lerVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}ª posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static void qtdNumPares(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                Console.Write(vetor[i] + ", ");
            }
        }
    }
}