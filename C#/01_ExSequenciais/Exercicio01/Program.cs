//1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

namespace Programa
{
    public class exercicio01
    {
        public static void Main() 
        {
            float x, y;
            float media;

            Console.WriteLine($"Digite o primeiro valor: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o segundo valor: ");
            y = float.Parse(Console.ReadLine());

            media = (x + y) / 2;

            Console.WriteLine($"Como você digitou os valores {x} e {y} a média é igual a {media:F2}");
            
        }
    }
}