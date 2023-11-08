// 5. Escreva um algoritmo para calcular o fatorial de um número.

public class Exercicio05
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        string numero = Console.ReadLine();

        int num = int.Parse(numero);
        int resultado = 0;
        int temp = 0;

        for (int i = num - 1; i > 0; i--)
        {
            if(i == num - 1)
            {
                resultado = num * i;
            }
            else
            {
                temp = i * resultado;
                resultado = temp;
            }
        }

        Console.WriteLine($"A fatorial de {num} é igual a {resultado}");
    }
}
