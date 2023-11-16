// 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

public class Exercicio08
{
    public static void Main()
    {
        int[,] matriz = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Valor para matriz: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{matriz[i, j]} - ");
            }
        }

        Console.WriteLine();

        for (int i = 3; i >= 0; i--)
        {
            for (int j = 3; j >= 0; j--)
            {
                Console.Write($"{matriz[i, j]} - ");
            }
        }
    }
}