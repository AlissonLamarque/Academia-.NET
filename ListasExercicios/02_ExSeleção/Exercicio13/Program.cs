/* 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7 */

public class Exercicio13
{
    public static void Main(string[] args)
    {
        double h, pesoIdeal = 0;
        string sexo;

        Console.WriteLine("Altura: ");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("Sexo (m/f): ");
        sexo = Console.ReadLine();

        if (sexo == "m")
        {
            pesoIdeal = (72.7 * h) - 58;
        }
        else if (sexo == "f")
        {
            pesoIdeal = (62.1 * h) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo informado inválido");
        }

        Console.WriteLine($"Peso ideal: {pesoIdeal}");
    }
}