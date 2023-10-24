// 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula da conversão é F=(9*C+160)/ 5.

public class Exercicio08
{
    public static void Main()
    {
        Console.WriteLine("Temperatura em Cº: ");
        int celsius = int.Parse(Console.ReadLine());

        int fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine($"{celsius}Cº = {fahrenheit}Fº");
    }
}