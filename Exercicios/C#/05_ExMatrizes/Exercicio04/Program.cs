/*
4) Popule uma matriz 5x5 e informe:
-Quantos números são pares
-Quantos números são impares
-Quantos números são positivos
-Quantos números são negativos
-Quantos zeros existem!
 */

public class Exercicio04
{
    public static void Main()
    {
        int[,] matriz = new int[5, 5];
        int cont = 0, contPar = 0, contImpar = 0, contPos = 0, contNeg = 0, contZero = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                cont++;
                matriz[i, j] = cont;
            }
        }

        for (int i = 0;i < 5; i++)
        {
            for (int j = 0;j < 5; j++)
            {
                if (matriz[i,j] % 2 == 0)
                    contPar++;
                else
                    contImpar++;
                if (matriz[i, j] > 0)
                    contPos++;
                else if (matriz[i, j] < 0)
                    contNeg++;
                else
                    contZero++;
            }
        }

        Console.WriteLine($"Quantos números são pares: {contPar}\nQuantos números são impares: {contImpar}\nQuantos números são positivos: {contPos}\nQuantos números são negativos: {contNeg}\nQuantos zeros existem: {contZero}");
    }
}