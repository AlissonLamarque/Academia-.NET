/* 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações. */

public class Exercicio09
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Valor da mercadoria: ");
        float valor = float.Parse(Console.ReadLine());

        float entrada, parcelas;

        if (valor % 3 != 0)
        {
            entrada = (valor / 3) + (valor % 3);
            parcelas = (valor - (valor % 3)) / 3;
        }
        else
        {
            entrada = (valor / 3);
            parcelas = (valor / 3);
        }

        Console.WriteLine($"Valor total: R${valor:F2}\nEntrada: {entrada:F2}\nParcelas: {entrada:F2}\n");
    }
}