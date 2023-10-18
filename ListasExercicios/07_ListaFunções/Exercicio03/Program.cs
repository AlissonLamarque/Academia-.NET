// 3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.

public class Exercicio03
{
    public static void Main()
    {
        double a, b, c;

        Console.WriteLine("Digite 3 valores: ");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        media3Val(a, b, c);
    }

    static void media3Val(double a, double b, double c)
    {
        Console.WriteLine($"A média dos valores é igual a {(a + b + c) / 3:F2}");
    }
}