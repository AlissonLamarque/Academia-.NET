// 6) Escreva uma função que calcule a média de um vetor de 10 números.

public class Exercicio06
{
    public static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite um valor para a {i + 1}ª posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"A média dos valores é igual a {calculoMedia(vetor)}");
    }

    static int calculoMedia(int[] vetor)
    {
        int resultado = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            resultado += vetor[i];
        }
        return resultado = resultado / vetor.Length;
    }
}