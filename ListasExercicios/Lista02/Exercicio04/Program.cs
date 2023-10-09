// 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
// Mostrar na tela qual dos professores tem o maior salário total.

public class Exercicio04
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Horas de aula do 1º professor: ");
        string horas1p = Console.ReadLine();
        Console.WriteLine("Valor por hora do 1º professor: ");
        string valor1p = Console.ReadLine();
        Console.WriteLine("Horas de aula do 2º professor: ");
        string horas2p = Console.ReadLine();
        Console.WriteLine("Valor por hora do 2º professor: ");
        string valor2p = Console.ReadLine();

        int horas1 = int.Parse(horas1p);
        int valor1 = int.Parse(valor1p);
        int horas2 = int.Parse(horas2p);
        int valor2 = int.Parse(valor2p);

        int salario1 = horas1 * valor1;
        int salario2 = horas2 * valor2;
        
        if (salario1 > salario2)
        {
            Console.WriteLine("O 1º professor tem o maior salário");
        }
        else
        {
            Console.WriteLine("O 2º professor tem o maior salário");
        }
    }
}