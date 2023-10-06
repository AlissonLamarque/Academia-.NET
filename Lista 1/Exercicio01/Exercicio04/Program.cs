//4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

namespace Programa
{
    public class exercicio01
    {
        public static void Main(String[] args)
        {
            string data;
           Data;

            Console.Write("Digite uma data [dd/mm/aaaa]: ");
            string data = Console.ReadLine();
            string []vetorData = data.Split('/');

            if (ano > 2023 || ano < 0001 || dia > 31 || dia < 01 || mes > 12 || mes < 01)
            {
                Console.WriteLine("Data inserida inválida.");
            }
            else
            {
                Console.WriteLine($"Formato AAAAMMDD: {ano}{mes}{dia}");
                if (ano >= 2000)
                {
                    Console.WriteLine($"Formato AAAAMMDD: {ano - 2000}{mes}{dia}");
                }
                else
                {
                    Console.WriteLine($"Formato AAAAMMDD: {ano - 1900}{mes}{dia}");
                }
            }
        }
    }
}