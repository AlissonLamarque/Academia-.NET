// 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. 
// A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

public class Exercicio01
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[5, 3];
        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        for (int i = 0; i < linha; i++)
        {
            Console.WriteLine("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            matriz[i, 0] = valor;
            matriz[i, 1] = valor + 10;
            matriz[i, 2] = valor * 2;
        }

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                Console.Write($"| {matriz[i, j]} |");
            }
            Console.WriteLine();
        }
    }
 }