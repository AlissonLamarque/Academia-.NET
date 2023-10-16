//2. Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

public class Exercicio02
{
    public static void Main(string[] args)
    {
        int maior = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um número: ");
            string numero = Console.ReadLine();

            int num = int.Parse(numero);

            if (i == 0)
            {
                maior = num;
            }
            else
            {
                if(num > maior)
                {
                    maior = num;
                }
            }

        }

        Console.WriteLine($"O maior numero digitado foi {maior}");
    }
}