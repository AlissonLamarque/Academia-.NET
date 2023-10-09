/* 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério */

public class Exercicio06
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nome: ");
        string nomeMin = Console.ReadLine();
        string nomeUp = nomeMin.ToUpper();

        Console.WriteLine("Altura: ");
        string alturaS = Console.ReadLine();

        float altura = float.Parse(alturaS);

        Console.WriteLine("Peso: ");
        string pesoS = Console.ReadLine();

        float peso = float.Parse(pesoS);

        float imc = peso / (altura * altura);

        if(imc < 18)
        {
            Console.WriteLine($"{nomeUp} - baixo peso ({imc:F2})");
        }
        if(imc > 35)
        {
            Console.WriteLine($"{nomeUp} - obesidade grau sério ({imc:F2})");
        }
        if (imc > 18 && imc < 25)
        {
            Console.WriteLine($"{nomeUp} - peso normal ({imc:F2})");
        }
        if (imc > 25 && imc < 30)
        {
            Console.WriteLine($"{nomeUp} - sobrepeso ({imc:F2})");
        }
        if (imc > 30 && imc < 35)
        {
            Console.WriteLine($"{nomeUp} - obesidade ({imc:F2})");
        }
    }
}