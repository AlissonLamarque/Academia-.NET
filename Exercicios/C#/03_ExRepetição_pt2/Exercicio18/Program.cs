// 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer
// elevada a um expoente qualquer, ou seja, NM.

public class Exercicio18
{
    public static void Main()
    {
        int expoente, bas;

        Console.Write("Base: ");
        bas = int.Parse(Console.ReadLine());
        Console.Write("Expoente: ");
        expoente = int.Parse(Console.ReadLine());

        Console.WriteLine($"{bas}^{expoente} = {Math.Pow(bas, expoente)}");
    }
}