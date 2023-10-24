/*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
    (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
    Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.*/

public class Exercicio01
{
    public static void Main(string[] args)
    {
        int numero = 0;

        do
        {
            Console.WriteLine("Digite um número inteiro positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Valor incorreto! Tente novamente.");
            }
            else
            {
                break;
            }

        } while (true);

        for (int i = 1; i < numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}