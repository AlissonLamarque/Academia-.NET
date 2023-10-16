// 12. Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N,
// fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a
// mensagem "O número fornecido não existe no vetor!".

public class Exercicio12
{
    public static void Main(string[] args)
    {
        int[] vetor = new int[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor que deseja encontrar no vetor: ");
        int valorPesquisa = int.Parse(Console.ReadLine());


    }
}