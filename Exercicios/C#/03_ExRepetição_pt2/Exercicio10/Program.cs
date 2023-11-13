/*
10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres.
 */

public class Exercicio10
{
    public static void Main()
    {
        string nome;
        char sexo;
        int idade, mediaIdade, somaIdade = 0, cont = 0, contM = 0, contF = 0, contI30 = 0, contS60 = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Seu sexo (m/f): ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write("Sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (sexo == 'm')
            {
                contM++;
            }
            else if (sexo == 'f')
            {
                contF++;
                cont++;
                somaIdade += idade;
            }
            if (idade < 30)
            {
                contI30++;
            }
            else if (idade > 60)
            {
                contS60++;
            }
        }

        mediaIdade = somaIdade / cont;

        Console.WriteLine($"Sexo Masculino: {contM}\nSexo Feminino: {contF}\nIdade inferior a 30 anos: {contI30}\nIdade superior a 60 anos: {contS60}\nMédia de idade das mulheres: {mediaIdade}");
    }
}