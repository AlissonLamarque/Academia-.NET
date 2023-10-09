// 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

public class Exercicio03
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor: ");
        string num1 = Console.ReadLine();

        int numero1 = int.Parse(num1);

        Console.WriteLine("Digite um valor: ");
        string num2 = Console.ReadLine();

        int numero2 = int.Parse(num1);

        Console.WriteLine("Digite um valor: ");
        string num3 = Console.ReadLine();

        int numero3 = int.Parse(num1);

        Console.WriteLine("Digite um valor: ");
        string num4 = Console.ReadLine();

        int numero4 = int.Parse(num1);

        int media = (numero1 + numero2 + numero3 + numero4) / 4;

        if (numero1 > media)
        {
            Console.WriteLine($"{numero1}");
        }
        if (numero2 > media)
        {
            Console.WriteLine(numero2);
        }
        if (numero3 > media)
        {
            Console.WriteLine(numero3);
        }
        if (numero4 > media)
        {
            Console.WriteLine(numero4);
        }

    }
} //DEU BRETTTTTTTTTTTTTTTTTTT