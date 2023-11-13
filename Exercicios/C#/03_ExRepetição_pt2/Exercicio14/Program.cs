// 14. Mostrar as potências de 2 variando de 0 a 10.

public class Exercicio14
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
        }
    }
}