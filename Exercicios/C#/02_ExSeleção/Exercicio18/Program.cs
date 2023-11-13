// 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

public class Exercicio18
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
                Console.WriteLine("Maior: 1º");
            }
            else
            {
                Console.WriteLine("Maior: 3º");
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("Maior: 2º");
            }
            else
            {
                Console.WriteLine("Maior: 3º");
            }
        }
    }
}