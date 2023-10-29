// 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

public class Exercicio03
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor: ");
        int numero3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor: ");
        int numero4 = int.Parse(Console.ReadLine());

        double media = (numero1 + numero2 + numero3 + numero4) / 4;

        Console.WriteLine("Valores acima da média: ");

        if (numero1 > media)
        {
            Console.WriteLine($"- {numero1}");
        }
        if (numero2 > media)
        {
            Console.WriteLine($"- {numero2}");
        }
        if (numero3 > media)
        {
            Console.WriteLine($"- {numero3}");
        }
        if (numero4 > media)
        {
            Console.WriteLine($"- {numero4}");
        }
    }
}