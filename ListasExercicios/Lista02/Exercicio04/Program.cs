// 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
// Mostrar na tela qual dos professores tem o maior salário total.

public class Exercicio04
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Horas de aula do 1º professor: ");
        int horas1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor por hora do 1º professor: ");
        float valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Horas de aula do 2º professor: ");
        int horas2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor por hora do 2º professor: ");
        float valor2 = int.Parse(Console.ReadLine());

        float salario1 = horas1 * valor1;
        float salario2 = horas2 * valor2;
        
        if (salario1 == salario2)
        {
            Console.WriteLine("Ambos professores tem o mesmo salário");
        }
        else
        {
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
}