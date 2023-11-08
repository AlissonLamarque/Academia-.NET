/* 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina. */

public class Exercicio09
{
    public static void Main()
    {
        Console.WriteLine("1º valor de glicemia: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2º valor de glicemia: ");
        int valor2 = int.Parse(Console.ReadLine());
        Console.WriteLine("3º valor de glicemia: ");
        int valor3 = int.Parse(Console.ReadLine());

        int media = (valor1 + valor2 + valor3) / 3;

        if (valor1 < 65 || valor2 < 65 || valor3 < 65)
        {
            Console.WriteLine("Corre risco de hipoglicemia");
        }
        else if (valor1 > 250 || valor2 > 250 || valor3 > 250)
        {
            Console.WriteLine("Corre risco de hiperglicemia");
        }
        if (media < 80)
        {
            Console.WriteLine("É preciso diminuir 2 unidades de insulina");
        }
        else if (media > 150)
        {
            Console.WriteLine("É preciso adicionar 2 unidades de insulina");
        }
        else
        {
            Console.WriteLine($"Média: {media}");
        }
    }
}