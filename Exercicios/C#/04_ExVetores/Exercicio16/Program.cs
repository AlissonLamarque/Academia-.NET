/* 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
•	A união de X com Y
•	A diferença entre X e Y
•	A interseção entre X e Y
Escreva o vetor resultado de cada uma das operações. */

public class Exercicio16
{
    public static void Main()
    {
        int[] X = new int[10];
        int[] Y = new int[10];

        int[] uniao = new int[20];
        int[] diferenca = new int[20];
        int[] intersecao = new int[10];

        int cont = 0, contINT = 0, contDIF = 0, contDIF2 = 0;

        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine("Valor para vetor X: ");
            X[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Y.Length; i++)
        {
            Console.WriteLine("Valor para vetor Y: ");
            Y[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < X.Length; i++)
        {
            contDIF = 0; contDIF2 = 0;
            for (int j = 0; j < X.Length; j++)
            {
                // Verifica os valores que existem em ambos vetores
                if (X[i] == Y[j])
                {
                    intersecao[contINT] = X[i];
                    contINT++;
                }

                // Verifica os valores do vetor X que não estão no vetor Y
                if (X[i] != Y[j])
                {
                    contDIF++;
                    if (contDIF == 10)
                    {
                        diferenca[cont] = X[i];
                        cont++;
                    }
                }

                // Verifica os valores do vetor Y que não estão no vetor X
                if (Y[i] != X[j])
                {
                    contDIF2++;
                    if (contDIF2 == 10)
                    {
                        diferenca[cont] = Y[i];
                        cont++;
                    }
                }

                // Faz a união de ambos vetores
                if (i == 0)
                    uniao[j] = X[j];
                else if (i == 1)
                {
                    for (int z = 1; z <= 10; z++)
                        if (!uniao.Contains(Y[z - 1]))
                            uniao[z + 9] = Y[z - 1];
                }
            }
        }


        Console.WriteLine("União: ");

        for (int i = 0; i < uniao.Length; i++)
            Console.Write($"{uniao[i]} - ");

        Console.WriteLine("\nDiferença: ");

        for (int i = 0; i < diferenca.Length; i++)
            Console.Write($"{diferenca[i]} - ");

        Console.WriteLine("\nInterseção: ");

        for (int i = 0;i < intersecao.Length; i++)
            Console.Write($"{intersecao[i]} - ");
    }
}
