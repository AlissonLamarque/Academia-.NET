/*
15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
Considerar nota 7,0 como mínima para aprovação.
 */

public class Exercicio15
{
    public static void Main()
    {
        double nota, somaNotas = 0, mediaNotas;

        for (int i = 0; i < 4;  i++)
        {
            Console.Write("Nota: ");
            nota = double.Parse(Console.ReadLine());

            if (i == 0 || i == 2)
            {
                nota *= 2;
            }
            if (i == 3)
            {
                nota *= 4;
            }

            somaNotas += nota;
        }

        mediaNotas = somaNotas / 9;

        if (mediaNotas >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}