/* 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. 
Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 
Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase. */

public class Exercicio16
{
    public static void Main()
    {
        Console.WriteLine("Time da casa: ");
        int golsCasa = int.Parse(Console.ReadLine());
        Console.WriteLine("Time de fora: ");
        int golsFora = int.Parse(Console.ReadLine());

        if (golsFora - golsCasa >= 2)
        {
            Console.WriteLine($"time da casa {golsCasa} x {golsFora} time de fora, o time de fora já se classificou");
        }
        else
        {
            Console.WriteLine($"time da casa {golsCasa} x {golsFora} time de fora, os dois times se enfrentarão em um novo jogo");

            Console.WriteLine("Time da casa: ");
            golsCasa = int.Parse(Console.ReadLine());
            Console.WriteLine("Time de fora: ");
            golsFora = int.Parse(Console.ReadLine());

            if (golsCasa > golsFora)
            {
                Console.WriteLine($"time da casa {golsCasa} x {golsFora} time de fora, o time da casa se classificou");
            }
            else
            {
                Console.WriteLine($"time da casa {golsCasa} x {golsFora} time de fora, o time de fora se classificou");
            }
        }
    }
}
