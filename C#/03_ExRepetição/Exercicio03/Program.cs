//3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.

public class Exercicio03
{
    public static void Main()
    {
        Console.WriteLine("Digite o numero que deseja ver a tabuada: ");
        string numero = Console.ReadLine();

        int num = int.Parse(numero);

        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine(num * i);
        }
    }
}