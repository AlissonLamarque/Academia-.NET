// 5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.

public class Exercicio05
{
    public static void Main()
    {
        Console.WriteLine("Temperatura em Cº: ");
        int celsius = int.Parse(Console.ReadLine());

        int fahrenheit = celsiusPFahrenheit(celsius);

        Console.WriteLine($"{celsius}Cº = {fahrenheit}Fº");
    }

    static int celsiusPFahrenheit( int celsius)
    {
        return (9 * celsius + 160) / 5;
    }
}