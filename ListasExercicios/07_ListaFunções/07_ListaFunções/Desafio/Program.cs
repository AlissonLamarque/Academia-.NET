// Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.

public class Desafio
{
    public static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}ª posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"O menor elemento do vetor é {menorElementoVetor(vetor)}"); 
    }

    static int menorElementoVetor(int[] vetor)
    {
        int menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }
}