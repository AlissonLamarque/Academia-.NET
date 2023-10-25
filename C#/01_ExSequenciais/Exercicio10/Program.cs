/* 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”. */

public class Exercicio10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Valor do saque: ");
        int valor = int.Parse(Console.ReadLine());

        int nota100, nota50, nota20, nota10, nota5, nota2, moeda1, constante;

        nota100 = valor / 100;
        constante = nota100 * 100;
        nota50 = (valor - constante) / 50;
        constante = nota100 * 100 + nota50 * 50;
        nota20 = (valor - constante) / 20;
        constante = nota100 * 100 + nota50 * 50 + nota20 * 20;
        nota10 = (valor - constante) / 10;
        constante = nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10;
        nota5 = (valor - constante) / 5;
        constante = nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10 + nota5 * 5;
        nota2 = (valor - constante) / 2;
        constante = nota100 * 100 + nota50 * 50 + nota20 * 20 + nota10 * 10 + nota5 * 5 + nota2 * 2;
        moeda1 = (valor - constante) / 1;

        Console.WriteLine($"- {nota100} notas de 100 reais\n" +
            $"- {nota50} nota(s) de 50 reais\n" +
            $"- {nota20} nota(s) de 20 reais\n" +
            $"- {nota10} nota(s) de 10 reais\n" +
            $"- {nota5} nota(s) de 5 reais\n" +
            $"- {nota2} nota(s) de 2 reais\n" +
            $"- {moeda1} moeda(s) de 1 real\n");
    }
}