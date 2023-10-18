// 1) Fazer uma calculadora das 4 operações (soma, subtração, multiplicação e divisão) Para isso, precisaremos aceitar números com vírgula.

public class Exercicio01
{
    public static void Main()
    {
        int op;
        double a, b;

        Console.WriteLine("Digite dois valores: ");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        do
        {

            Console.Write("Qual operação deseja realizar?\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair\nSua opção: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    soma(a, b);
                    break;
                case 2:
                    subtracao(a, b);
                    break;
                case 3:
                    multiplicacao(a, b);
                    break;
                case 4:
                    divisao(a, b);
                    break;
                case 5:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opcão inválida! Tente novamente.");
                    break;
            }
        } while (op != 5);
    }

    static void soma(double a, double b)
    {
        double resultado = a + b;
        Console.WriteLine($"{a} + {b} = {resultado}");
    }
    static void subtracao(double a, double b)
    {
        double resultado = a - b;
        Console.WriteLine($"{a} - {b} = {resultado}");
    }
    static void multiplicacao(double a, double b)
    {
        double resultado = a * b;
        Console.WriteLine($"{a} * {b} = {resultado}");
    }
    static void divisao(double a, double b)
    {
        double resultado = a / b;
        Console.WriteLine($"{a} / {b} = {resultado}");
    }
}