// 12. Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N,
// fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a
// mensagem "O número fornecido não existe no vetor!".

public class Exercicio12
{
    public static void Main()
    {
        int[] vetor = new int[10];
        bool valorEncontrado = false;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor que deseja encontrar no vetor: ");
        int valorPesquisa = int.Parse(Console.ReadLine());

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valorPesquisa)
            {
                Console.WriteLine($"O valor foi encontrado no índice {i}");
                valorEncontrado = true;
            }
        }

        if (!valorEncontrado)
        {
            Console.WriteLine("O valor fornecido não existe no vetor");
        }
    }
}