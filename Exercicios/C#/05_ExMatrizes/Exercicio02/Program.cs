/* 2) Solicite ao usuário, preencher uma Matriz 3x3

Informe ao usuário:
*A soma dos elementos de cada linha
	-Ex: Linha 1: 30
	     Linha 2: 17
*A soma dos elementos de cada coluna
	-Ex: Coluna 1: 23
	     Coluna 2: 36 */

public class Exercicio02
{
	public static void Main()
	{
		int[,] matriz = new int[3, 3];
        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);
		int somaLinha = 0, somaColuna = 0, contador = 0;

        for (int i = 0; i < linha; i++)
		{
			for (int j = 0; j < coluna; j++)
			{
				Console.WriteLine($"Digite um valor para a posição [{i},{j}] da matriz: ");
				matriz[i, j] = int.Parse(Console.ReadLine());
			}
		}

        Console.WriteLine("Soma dos elementos de cada linha");

        for (int i = 0; i < linha; i++)
        {
			contador = 0; somaLinha = 0;
            for (int j = 0; j < coluna; j++)
            {
                somaLinha += matriz[i, j];
				contador++;

				if (contador == 3)
					Console.WriteLine($"Linha {i + 1}: {somaLinha}");
            }
        }

        Console.WriteLine("Soma dos elementos de cada coluna");

        for (int i = 0; i < linha; i++)
        {
            contador = 0; somaColuna = 0;
            for (int j = 0; j < coluna; j++)
            {
                somaColuna += matriz[j, i];
                contador++;

                if (contador == 3)
                    Console.WriteLine($"Coluna {i + 1}: {somaColuna}");
            }
        }
    }
}