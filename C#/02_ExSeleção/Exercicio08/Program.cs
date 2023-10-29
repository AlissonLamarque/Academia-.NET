/* 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas.  */

public class Exercicio08
{
    public static void Main()
    {
        Console.WriteLine("Código: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Salário base (R$): ");
        double salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Total de vendas (R$): ");
        double totalVendas = double.Parse(Console.ReadLine());

        if (totalVendas > 5000)
        {
            salario += totalVendas * 0.1;
        }
        else
        {
            if (totalVendas > 1000)
            {
                salario += totalVendas * 0.07;
            }
            else
            {
                if (totalVendas > 500)
                {
                    salario += totalVendas * 0.05;
                }
            }
        }

        Console.WriteLine($"{codigo} - {nome}: R${salario}");
    }
}
