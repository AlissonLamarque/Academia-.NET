/*
7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.
 */

public class Exercicio07
{
    public static void Main()
    {
        string nome;
        int idade;
        double salario;
        bool infValida = false;

        do
        {
            Console.Write("Seu nome: ");
            nome = Console.ReadLine();

            if (int.TryParse(nome, out idade))
            {
                Console.WriteLine("Nome inválido");
                break;
            }
            else
            {
                if (nome == "")
                {
                    Console.WriteLine("Nome inválido");
                    break;
                }
            }

            Console.Write("Sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 0)
            {
                Console.WriteLine("Idade inválida");
                break;
            }

            Console.Write("Seu salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 0)
            {
                Console.WriteLine("Salário inválido");
                break;
            }

            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nSalário: {salario:F2}");
            infValida = true;
        } while (!infValida);
    }
}