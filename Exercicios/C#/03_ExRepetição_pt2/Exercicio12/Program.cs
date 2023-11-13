//12. Apresentar o total da soma dos cem primeiros números inteiros.

public class Exercicio12
{
    public static void Main()
    {
        int soma = 0;

        for (int i = 1; i < 101; i++)
        {
            soma += i;
        }

        Console.WriteLine(soma);
    }
}