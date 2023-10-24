/* 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto. */

public class Exercicio10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1º ATLETA");
        Console.WriteLine("Nome: ");
        string nome1 = Console.ReadLine();
        Console.WriteLine("Idade: ");
        int idade1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Altura: ");
        double altura1 = double.Parse(Console.ReadLine());

        Console.WriteLine("2º ATLETA");
        Console.WriteLine("Nome: ");
        string nome2 = Console.ReadLine();
        Console.WriteLine("Idade: ");
        int idade2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Altura: ");
        double altura2 = double.Parse(Console.ReadLine());

        if (idade1 == idade2)
        {
            if (altura1 == altura2)
            {
                Console.WriteLine($"Mais novo: ambos tem {idade1} anos\nMais alto: ambos tem {altura1}m");
            }
            else
            {
                if (altura1 > altura2)
                {
                    Console.WriteLine($"Mais novo: ambos tem {idade1} anos\nMais alto: {nome1} - ({altura1}m)");
                }
                else
                {
                    Console.WriteLine($"Mais novo: ambos tem {idade1} anos\nMais alto: {nome2} - ({altura2}m)");
                }
            }    
        }
        else
        {
            if (idade1 < idade2)
            {
                if (altura1 == altura2)
                {
                    Console.WriteLine($"Mais novo: {nome1} - ({idade1} anos)\nMais alto: ambos tem {altura1}m");
                }
                else
                {
                    if (altura1 > altura2)
                    {
                        Console.WriteLine($"Mais novo: {nome1} - ({idade1} anos)\nMais alto: {nome1} - ({altura1}m)");
                    }
                    else
                    {
                        Console.WriteLine($"Mais novo: {nome1} - ({idade1} anos)\nMais alto: {nome2} - ({altura2}m)");
                    }
                }     
            }
            else
            {
                if (altura1 == altura2)
                {
                    Console.WriteLine($"Mais novo: {nome2} - ({idade2} anos)\nMais alto: ambos tem {altura1}m");
                }
                else
                {
                    if (altura2 > altura1)
                    {
                        Console.WriteLine($"Mais novo: {nome2} - ({idade2} anos)\nMais alto: {nome2} - ({altura2}m)");
                    }
                    else
                    {
                        Console.WriteLine($"Mais novo: {nome2} - ({idade2} anos)\nMais alto: {nome1} - ({altura1}m)");
                    }
                } 
            }
        }
    }
}
