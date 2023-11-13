/*
11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
 */

public class Exercicio11
{
    public static void Main()
    {
        int leitura, alunos = 0;
        double nota, somaNotas = 0, maiorNota = 0, menorNota = 0, mediaNotas;

        do
        {
            Console.Write("Nota: ");
            nota = double.Parse(Console.ReadLine());
            alunos++;

            somaNotas += nota;

            if (alunos == 1)
            {
                maiorNota = nota;
                menorNota = nota;
            }
            else
            {
                if (maiorNota < nota)
                    maiorNota = nota;
                if (menorNota > nota)
                    menorNota = nota;
            }

            Console.Write("Deseja continuar a leitura?\n(-1 para sair): ");
            leitura = int.Parse(Console.ReadLine());
        } while (leitura != -1);

        mediaNotas = somaNotas / alunos;

        Console.WriteLine($"Nota mais alta: {maiorNota}\nMenor nota: {menorNota}\nMédia da turma: {mediaNotas:F2}\nQuantidade de alunos: {alunos}");
    }
}