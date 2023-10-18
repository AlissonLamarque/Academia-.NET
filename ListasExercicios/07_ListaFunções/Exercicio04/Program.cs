// 4) Escreva uma função que calcule o fatorial de um número inteiro positivo.

public class Exercicio04
{
    public static void Main()
    {
        int num;
        Console.WriteLine("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        fatorial(num);
    }

    static void fatorial(int num)
    {
        int temp, resultado = 0;

        for (int i = num - 1; i > 0; i--)
        {
            if (i == num - 1)
            {
                resultado = num * i;
            }
            else
            {
                temp = i * resultado;
                resultado = temp;
            }
        }

        Console.WriteLine($"{num}! = {resultado}");
    }
}