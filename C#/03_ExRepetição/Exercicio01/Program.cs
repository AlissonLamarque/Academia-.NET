//1. Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.

public class Exercicio01
{
    public static void Main()
    {
        int temp = 0, contador = 0, quant = 0, idade = 0;
        string idadeString, quantString;

        Console.WriteLine("Digite um número: ");
        quantString = Console.ReadLine();

        quant = int.Parse(quantString);

        for (int i = 0; i < quant; i++)
        {
            Console.WriteLine("Digite uma idade: ");
            idadeString = Console.ReadLine();

            idade = int.Parse(idadeString);
            temp += idade;

            contador++;
        }

        float media = temp / contador;
        Console.WriteLine($"A media das idades informadas é igual a {media:F2}");
    }
}
