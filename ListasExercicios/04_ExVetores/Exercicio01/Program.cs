// 1. Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a
// quantidade de números pares e ímpares.

public class Exercicio01
{
    public static void Main(string[] args)
    {
        int[] vetor = new int[10];
        int contadorPar = 0, contadorImpar = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a posição {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] % 2 == 0)
            {
                contadorPar += 1;
            }
            else
            {
                contadorImpar += 1;
            }
        }

        Console.WriteLine($"Foram digitados {contadorPar} números pares e {contadorImpar} números ímpares");
    }
}

