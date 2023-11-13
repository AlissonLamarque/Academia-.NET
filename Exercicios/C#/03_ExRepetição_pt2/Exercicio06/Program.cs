/*
6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.
 */

public class Exercicio06
{
    public static void Main()
    {
        int idade;
        bool idValida = false;

        do
        {
            Console.WriteLine("Sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 0 && idade < 130)
            {
                idValida = true;
            }
        } while (!idValida);

        Console.WriteLine($"Idade: {idade} anos");
    }
}