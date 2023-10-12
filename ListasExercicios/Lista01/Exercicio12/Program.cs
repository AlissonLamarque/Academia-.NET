/* 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90) */

public class Exercicio12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Marcação do odômetro no início do dia: ");
        float odomInicio = float.Parse(Console.ReadLine());
        Console.WriteLine("Marcação do odômetro no fim do dia: ");
        float odomFinal = float.Parse(Console.ReadLine());
        Console.WriteLine("Combustível gasto (L): ");
        int combGasto = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor total recebido (R$): ");
        float valorTotal = float.Parse(Console.ReadLine());

        float kmTotal = odomFinal - odomInicio;
        float consumoMedio = kmTotal / combGasto;
        double lucroDia = valorTotal - (combGasto * 6.90);

        Console.WriteLine($"Média de consumo: {consumoMedio:F2}Km/l\nLucro Líquido do dia: R${lucroDia:F2}");
    }
}