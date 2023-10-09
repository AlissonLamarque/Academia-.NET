// 9. Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em
// seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

DEU BRET

public class Exercicio09
{
    public static void Main(string[] args)
    {
        int[] vetor = new int[10];
        int[] vetorAux = new int[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            int contador = 0;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                if (i == 0)
                {
                    vetorAux[i] = vetor[i];
                }

                if (vetorAux[i] > vetor[i + 1])
                {
                    vetorAux[i + 1] = vetor[i];
                    vetor[i] = vetor[i + 1];
                }
                else
                {
                    contador++;
                }
            }

            if(contador == 9)
            {
                break;
            }

        }

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($" |{vetor[i]}| ");
        }

    }
}

