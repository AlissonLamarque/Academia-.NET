// 3. Fazer um laço (repetição) que fique solicitando números ao usuário.
// Se o usuário digitar 0 o programa em VS deve parar. Caso contrário, o
// programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   

public class Exercicio03
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero == 0)
            {
                Console.WriteLine("Saindo do sistema...");
                break;
            }
            else
            {
                Console.WriteLine("Este número é...");

                if(numero % 2 == 0)
                {
                    Console.WriteLine("Par");
                }
                else
                {
                    Console.WriteLine("Ímpar");
                }

                if(numero <= 1 )
                {
                    Console.WriteLine("E não é primo");
                }
                else
                {
                    if(numero == 2 || numero == 3 || numero == 5 || numero == 7)
                    {
                        Console.WriteLine("E primo");
                    }
                    else
                    {
                        if (numero % 2 == 0 || numero % 3 == 0 || numero % 5 == 0 || numero % 7 == 0)
                        {
                            Console.WriteLine("E não é primo");
                        }
                        else
                        {
                            Console.WriteLine("E primo");
                        }
                    }
                }

            }
        } while (true);
    }
}
