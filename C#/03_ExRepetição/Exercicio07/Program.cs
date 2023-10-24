// 7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.

public class Exercicio07
{
    public static void Main(string[] args)
    {
        int contPar = 0, contImpar = 0;

        for (int i = 1; i <= 20; i++) 
        { 
            Console.WriteLine($"Digite o {i}º número: ");
            string numero = Console.ReadLine();

            int num = int.Parse(numero);

            if (num % 2 == 0)
            {
                contPar++;
            }
            else
            {
                contImpar++;
            }
        }

        Console.WriteLine($"Foram digitados {contPar} número(s) pares e {contImpar} número(s) ímpares.");
    }
}