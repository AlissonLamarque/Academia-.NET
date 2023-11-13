/*
8. Faça um programa em VS que solicite um numero inteiro. Se o numero 
não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
 */

public class Exercicio08
{
    public static void Main()
    {
        string numero;
        char resposta;
        int numeroInt;
        bool numeroValido = false;

        do
        {
            Console.Write("Digite um número inteiro: ");
            numero = Console.ReadLine();

            if (int.TryParse(numero, out numeroInt))
            {
                if (numeroInt % 2 == 0)
                {
                    Console.WriteLine("Número Par");
                }
                else
                {
                    Console.WriteLine("Número Ímpar");
                }
            }
            else
            {
                Console.WriteLine("Número inválido! Tente novamente");
                continue;
            }

            Console.Write("Deseja repetir o programa?\n(s/n): ");
            resposta = char.Parse(Console.ReadLine());
            if (resposta == 's')
                continue;
            else
                numeroValido = true;

        } while (!numeroValido);
    }
}