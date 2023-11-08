// 4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

public class Exercicio04
{
    public static void Main()
    {
        int numTemp = 0, resultado = 1;

        Console.WriteLine("Digite um número: ");
        string numerox = Console.ReadLine();
        Console.WriteLine("Digite outro número: ");
        string numeroy = Console.ReadLine();

        int numx = int.Parse(numerox);
        int numy = int.Parse(numeroy);

        for (int i = 1; i <= numy; i++) 
        {   
            if(i == 1)
            {
                continue;
            }
            if (i == 2)
            {
                resultado = numx * numx;
            }
            else
            {
                numTemp = resultado * numx;
                resultado = numTemp;
            }
        }

        Console.WriteLine($"{numx} elevado na potencia de {numy} é igual a {resultado}");
    }
}
