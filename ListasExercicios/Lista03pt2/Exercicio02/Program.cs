// 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
// informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
public class Exercicio02
{
    public static void Main(string[] args)
    {
        do
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

            Console.WriteLine("Digite 'sim' se deseja digitar outro número: ");
            string resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                continue;
            }
            else
            {
                break;
            }
        } while (true);
    }
}