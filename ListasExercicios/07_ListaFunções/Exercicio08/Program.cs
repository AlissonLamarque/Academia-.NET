// 8) Ler um número inteiro e passar por parâmetro para uma função e 0, se o número é par, ou 1, se o número é ímpar.

public class Exercicio08
{
    public static void Main()
    {
        int numero;
        Console.WriteLine("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine(funcao(numero));
    }

    static int funcao(int numero)
    {
        if (numero % 2 == 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}