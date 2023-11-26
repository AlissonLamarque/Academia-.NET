// 6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de
// coluna como parâmetros, e retorna a soma dos elementos nessa coluna.

public class Exercicio06
{
    public static void Main()
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int resposta, soma;

        Console.WriteLine("Qual coluna deseja somar: ");
        resposta = int.Parse(Console.ReadLine());

        soma = MediaColunaMatriz(matriz, resposta);
        Console.WriteLine($"Soma igual a {soma}");
    }

    public static int MediaColunaMatriz(int[,] matriz, int coluna)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, coluna];
        }

        return soma;
    }
}