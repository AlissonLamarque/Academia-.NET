//2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

namespace Programa
{
    public class exercicio01
    {
        public static void Main(String[] args)
        {
            int x, y, z, a;
            float media;

            Console.WriteLine($"Digite o primeiro valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o segundo valor: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o terceiro valor: ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o quarto valor: ");
            a = int.Parse(Console.ReadLine());

            media = (x + y + z + a) / 4;

            Console.WriteLine($"Como voce digitou os valores {x}, {y}, {z} e {a} a média é igual a {media}");

        }
    }
}
