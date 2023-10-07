//5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km/l), sendo que são conhecidos
//a distância total percorrida e o volume de combustível consumido para percorrê-la (medido em l).

public class Exercicio05
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Distância percorrida (km): ");
        string dist = Console.ReadLine();

        int distancia = int.Parse(dist);

        Console.WriteLine("Volume de combustível consumido (L): ");
        string comb = Console.ReadLine();

        int combustivel = int.Parse(comb);

        float consumo = distancia / combustivel;

        Console.WriteLine($"O consumo médio do automóvel é igual a: {consumo:F2}Km/l");
    }
}