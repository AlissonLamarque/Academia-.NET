// 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o
// preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
// vendidas pelo vendedor, calcule e mostre: o salário do empregado

public class Exercicio13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Valor do salário mínimo: ");
        float salarioMin = float.Parse(Console.ReadLine());
        Console.WriteLine("Preço de custo de cada bicicleta: ");
        float custoBicicleta = float.Parse(Console.ReadLine());
        Console.WriteLine("Nr de bicicletas vendidas: ");
        int nrVendas= int.Parse(Console.ReadLine());

        double percentualCusto = custoBicicleta * 0.15;
        double salarioVendedor = (salarioMin * 2) + (percentualCusto * nrVendas);

        Console.WriteLine($"Salário do vendedor: R${salarioVendedor:F2}");
    }
}