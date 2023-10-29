// 10. Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo
// os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

public class Exercicio10
{
    public static void Main()
    {
        int[] vetor = new int[20];
        int[] vetor2 = new int[20];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0;i < vetor2.Length; i++)
        {
            if (vetor[i] != 0)
            {
                vetor2[i] = vetor[i];
            }
            else
            {
                vetor2[i] = 2;
            }
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($" |{vetor[i]}| ");
        }

        Console.WriteLine("");

        for (int i = 0; i < vetor2.Length; i++)
        {
            Console.Write($" |{vetor2[i]}| ");
        }
    }
}

