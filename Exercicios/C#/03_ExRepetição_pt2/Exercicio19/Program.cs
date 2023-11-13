/*
19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo.
 */

public class Exercicio19
{
    public static void Main()
    {
        double salario, somaSalario = 0, mediaSalario, maiorSalario = 0, percentSalario = 0;
        int filhos, somaFilhos = 0, mediaFilhos, cont = 0;

        do
        {
            Console.Write("Nr de filhos: ");
            filhos = int.Parse(Console.ReadLine());

            Console.Write("Salário R$: ");
            salario = double.Parse(Console.ReadLine());

            if (cont == 0)
            {
                maiorSalario = salario;
            }
            else
            {
                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
            }

            if (salario < 100)
                percentSalario ++;

            somaFilhos += filhos;
            somaSalario += salario;
            cont++;
        } while (salario > 0);

        mediaFilhos = somaFilhos / cont;
        mediaSalario = somaSalario / cont;
        percentSalario = percentSalario * 100 / cont;

        Console.WriteLine($"Média Salário: R${mediaSalario:F2}\nMédia nr filhos: {mediaFilhos}\nMaior salário: {maiorSalario}\nPercentual até R$100: {percentSalario}%");
    }
}