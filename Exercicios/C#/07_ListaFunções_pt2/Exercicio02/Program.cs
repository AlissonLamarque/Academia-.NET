// 2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números,
// a informação se o usuário deseja escolher os pares ou os impares, e retorna
// a média dos valores conforme a escolha do usuário.

public class Exercicio02
{
    public static void Main()
    {
        int[] vetor = new int[10];
        int resposta, media;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Clear();

        Console.Write("Calculadora de Média\n1 - Pares\n2 - Ímpares\nSua opção: ");
        resposta = int.Parse(Console.ReadLine());

        media = CalcularMedia(vetor, resposta);
        Console.WriteLine($"A média é igual a {media}");
    }

    public static int CalcularMedia(int[] vetor, int opcao)
    {
        int somaValores = 0, cont = 0;

        if (opcao == 1)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    somaValores += vetor[i];
                    cont++;
                }
            }
        }
        else if (opcao == 2)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    somaValores += vetor[i];
                    cont++;
                }
            }
        }

        return somaValores / cont;
    }
}
