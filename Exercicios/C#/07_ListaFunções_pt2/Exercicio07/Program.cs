// 7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números
// inteiros como parâmetro e retorna verdadeiro se pelo menos um número primo
// estiver presente no vetor, e falso caso contrário.

public class Exercicio07
{
    public static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1}º valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        if (VerificarNumeroPrimo(vetor))
        {
            Console.WriteLine("Existem números primos");
        }
        else
        {
            Console.WriteLine("Não existem números primos");

        }
    }

    public static bool VerificarNumeroPrimo(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            int numero = vetor[i], cont = 0;

            for (int j = 1; j <= numero; j++)
            {
                if (numero % j == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                return true;
            }
        }

        return false;
    }
}
