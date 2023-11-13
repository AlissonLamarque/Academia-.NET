/*
16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N*3*3; N*3*3*3; etc).
 */

public class Exercicio16
{
    public static void Main()
    {
        int n, produto;

        do
        {
            Console.Write("Número: ");
            n = int.Parse(Console.ReadLine());

        } while (n > 50 || n < 0);

        produto = n;
        Console.Write(n);

        do
        {
            produto *= 3;
            Console.Write("*3");
        } while (produto < 250);

        Console.Write($" = {produto}");
    }
}