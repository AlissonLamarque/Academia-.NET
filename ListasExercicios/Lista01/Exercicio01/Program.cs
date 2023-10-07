//1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

namespace Programa
{
    public class exercicio01
    {
        public static void Main(String[] args) 
        {
            int x, y;
            float media;

            Console.WriteLine($"Digite o primeiro valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o segundo valor: ");
            y = int.Parse(Console.ReadLine());

            media = (x + y) / 2;

            Console.WriteLine($"Como voce digitou os valores {x} e {y} a média é igual a {media}");
            
        }
    }
}