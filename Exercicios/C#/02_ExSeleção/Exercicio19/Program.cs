// 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

public class Exercicio19
{
    public static void Main()
    {
        int a, b, c;

        Console.Write("1º: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("2º: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("3º: ");
        c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine($"{c},{b},{a}");
                }
                else
                {
                    Console.WriteLine($"{b},{c},{a}");
                }
            }
            else
            {
                Console.WriteLine($"{b},{a},{c}");
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{c},{a},{b}");
                }
                else
                {
                    Console.WriteLine($"{a},{c},{b}");
                }
            }
            else
            {
                Console.WriteLine($"{a},{b},{c}");
            }
        }
    }
}