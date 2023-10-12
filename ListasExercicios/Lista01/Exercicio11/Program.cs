// 11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos.
// Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

public class Exercicio11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nr de eleitores no município: ");
        int eleitores = int.Parse(Console.ReadLine());

        Console.WriteLine("Nr de votos brancos: ");
        int votoB = int.Parse(Console.ReadLine());
        Console.WriteLine("Nr de votos nulos: ");
        int votoN = int.Parse(Console.ReadLine());
        Console.WriteLine("Nr de votos válidos: ");
        int votoV = int.Parse(Console.ReadLine());

        int percentualB = (votoB * 100) / eleitores;
        int percentualN = (votoN * 100) / eleitores;
        int percentualV = (votoV * 100) / eleitores;

        Console.WriteLine($"DIVISÃO DOS VOTOS\n{percentualB}% - Branco\n{percentualN}% - Nulo\n{percentualV}% - Válido");
    }
}
