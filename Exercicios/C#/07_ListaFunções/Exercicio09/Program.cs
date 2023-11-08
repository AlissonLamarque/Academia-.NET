// 9) Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) e retorna a soma dos números inteiros
// que existem entre n1 e n2 (inclusive ambos). Apresente o resultado na main.

public class Exercicio09
{
    public static void Main()
    {
        int n1, n2;

        Console.WriteLine("Digite dois números: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"A soma dos valores de {n1} ate {n2} é igual a {somaN1N2(n1, n2)}");
    }

    static int somaN1N2(int n1, int n2)
    {
        int soma = 0;

        for (int i = n1; i <= n2; i++)
        {
            soma += i;
        }

        return soma;
    }
}