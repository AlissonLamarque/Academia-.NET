/* 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes). */

public class Exercicio17
{
    public static void Main()
    {
        double a, b, c;

        Console.WriteLine("Lado A: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Lado B: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Lado C: ");
        c = double.Parse(Console.ReadLine());

        if (a <= b + c && b <= c + a && c <= a + b)
        {
            if (a == b && a == c)
            {
                Console.WriteLine("Equilátero");
            }
            else if (a == b && a != c || a == c && a != b || b == c && c != a)
            {
                Console.WriteLine("Isósceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não foi possível formar um triângulo");
        }

    }
}