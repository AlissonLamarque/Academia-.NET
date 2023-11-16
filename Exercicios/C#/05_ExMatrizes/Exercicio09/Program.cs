/*
9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
 */

public class Exercicio09
{
    public static void Main()
    {
        int[,] matriz = new int[3, 3];
        int valor;
        bool valorExiste = false;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Valor para matriz: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Valor que deseja encontrar: ");
        valor = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] == valor)
                    valorExiste = true;
            }
        }

        if (valorExiste)
            Console.WriteLine("O número existe no vetor");
        else
            Console.WriteLine("Número inexistente");
    }
}