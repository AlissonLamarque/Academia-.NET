/*
13. Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500.
 */

public class Exercicio13
{
    public static void Main()
    {
        int soma = 0;

        for (int i = 1; i < 501; i++)
        {
            if (i % 2 == 0)
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}