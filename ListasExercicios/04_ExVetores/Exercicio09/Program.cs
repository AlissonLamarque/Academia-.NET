// 9. Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em
// seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

public class Exercicio09
{
    public static void Main(string[] args)
    {
        int[] vetor = new int[10];
        int aux = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            for (int j = 0; j < (vetor.Length - 1); j++)
            {
                if (vetor[j + 1] < vetor[j])
                {
                    aux = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = aux;
                }
            }
        }


        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($" |{vetor[i]}| ");
        }

    }
}

