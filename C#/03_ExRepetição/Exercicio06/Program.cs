//6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma. Por fim, leia as notas das
//avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).

public class Exercicio06
{
    public static void Main()
    {
        int somaNotas = 0, cont = 0;

        Console.WriteLine("Digite o número de alunos da turma: ");
        string quantidadeAlunos = Console.ReadLine();
        Console.WriteLine("Quantas avaliações foram aplicadas para esta turma: ");
        string quantidadeAvaliacoes = Console.ReadLine();

        int quantAluno = int.Parse(quantidadeAlunos);
        int quantAvaliacoes = int.Parse(quantidadeAvaliacoes);

        for (int i = 1; i <= quantAluno; i++)
        {
            for (int j = 1; j <= quantAvaliacoes; j++)
            {
                Console.WriteLine($"Qual foi a nota do {i}º aluno na {j}ª avaliação: ");
                string notaString = Console.ReadLine();

                int nota = int.Parse(notaString);

                somaNotas += nota;
                cont++;
            }
        }

        float mediaFinal = somaNotas / cont;
        Console.WriteLine($"A média final das notas ficou igual a {mediaFinal:F2}");
    }
}