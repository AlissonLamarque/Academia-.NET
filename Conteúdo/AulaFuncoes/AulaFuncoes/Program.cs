namespace AulaFuncoes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Console.WriteLine("Oi pessoal, neste exemplo irei apresentar funções!");
            apresentarMensagem();

            ler2Num();
            somar2Num();*/

            double a, b;

            a = lerNum();
            b = lerNum();

            somar2Num(a, b);

            /*static void apresentarMensagem()
            {
                Console.WriteLine("Eu estou aqui na função!");
            }

            static void ler2NumSoma()
            {
                //ler dois numeros e somar eles
                double resultado;
                Console.WriteLine("Digite dois números: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                resultado = a + b;
                Console.WriteLine($"O resultado da soma é igual a {resultado}");
            }

            static void ler2Num()
            {
                Console.WriteLine("Digite dois números: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

            }*/

            static double lerNum()
            {
                double a;

                Console.WriteLine("Digite dois números: ");
                a = double.Parse(Console.ReadLine());

                return a;
            }


            static void somar2Num(double a, double b)
            {
                double resultado;

                resultado = a + b;
                Console.WriteLine($"O resultado da soma é igual a {resultado}");
            }
        }
    }
}