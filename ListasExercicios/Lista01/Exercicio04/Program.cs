//4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.
//Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

namespace Programa
{
    public class exercicio01
    {
        public static void Main(String[] args)
        {
            Console.Write("Digite uma data [dd/mm/aaaa]: ");
            string data = Console.ReadLine();
            string []vetorData = data.Split('/');

            Console.WriteLine(vetorData[2] + "/" + vetorData[1] + "/" + vetorData[0]);

            string ano = vetorData[2];
            Console.WriteLine(ano.Substring(2) + "/" + vetorData[1] + "/" + vetorData[0]);
        }
    }
}