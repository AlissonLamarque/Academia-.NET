// 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado”
// se a média das duas notas for maior ou igual a 7,0. 

public class Exercicio05
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1ª nota: ");
        string notaum = Console.ReadLine();
        Console.WriteLine("2ª nota: ");
        string notadois = Console.ReadLine();

        int nota1 = int.Parse(notaum);
        int nota2 = int.Parse(notadois);

        if ((nota1 + nota2) / 2 >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}