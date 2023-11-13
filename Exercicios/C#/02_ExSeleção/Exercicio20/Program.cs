// 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”.
// plus: você pode gerar o número de forma randomica (função random c#).

public class Exercicio20
{
    public static void Main()
    {
        Random random = new Random();
        int aleatorio = random.Next(1, 101), chute;
        bool acerto = false;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Seu chute: ");
            chute = int.Parse(Console.ReadLine());

            if (chute == aleatorio)
            {
                Console.WriteLine("Você acertou");
                acerto = true;
                break;
            }
            else
            {
                Console.WriteLine("Você errou");
                if (chute > aleatorio)
                {
                    Console.WriteLine("É menor");
                }
                else
                {
                    Console.WriteLine("É maior");
                }
            }
        }
        if (!acerto)
        {
            Console.WriteLine($"Não foi dessa vez. O número correto era {aleatorio}");
        }
    }
}
