// 7) Crie uma função que determine se um número é primo ou não.

public class Exercicio07
{
    public static void Main()
    {
        int numero;
        Console.WriteLine("Digite um valor: ");
        numero = int.Parse(Console.ReadLine());

        if (verificaPrimo(numero))
        {
            Console.WriteLine($"O número {numero} é primo");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é primo");
        }
    }

    static bool verificaPrimo(int numero)
    {
        int contador = 0;

        for (int i = numero; i > 0; i--)
        {
            if (numero % i == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}