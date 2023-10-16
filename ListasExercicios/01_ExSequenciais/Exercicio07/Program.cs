// 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e
// o percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

public class Exercicio07
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Número do vendedor: ");
        int nrVendedor = int.Parse(Console.ReadLine());

        Console.WriteLine("Salário fixo: ");
        float salarioFixo = float.Parse(Console.ReadLine());

        Console.WriteLine("Total de vendas: ");
        float totalVendas = float.Parse(Console.ReadLine());

        Console.WriteLine("Percentual sobre o total de vendas: ");
        float percentual = float.Parse(Console.ReadLine());

        float salarioTotal = (totalVendas * (percentual / 100)) + salarioFixo;

        Console.WriteLine($"Vendedor nr{nrVendedor}: R${salarioTotal:F2}");
    }
}