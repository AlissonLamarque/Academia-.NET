// 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

public class Exercicio02
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        string num = Console.ReadLine();

        int numero = int.Parse(num);

        if (numero % 2 == 0 )
        {
            Console.WriteLine($"O número {numero} é par");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar");
        }
    }
}