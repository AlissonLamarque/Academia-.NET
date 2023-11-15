// 14. Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
// Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido.
// Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

public class Exercicio14
{
    public static void Main()
    {
        int[] vetor = new int[10];
        int codigo;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("1 - Sair\n2 - Vetor asc\n3 - Vetor dcs");
        codigo = int.Parse(Console.ReadLine());

        if (codigo == 2)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($"{vetor[i]} - ");
        }
        else if (codigo == 3)
        {
            for (int i = vetor.Length - 1; i > -1; i--)
                Console.Write($"{vetor[i]} - ");
        }
        else
        {
            Console.WriteLine("Saindo do sistema...");
        }
    }
}