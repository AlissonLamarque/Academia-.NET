using ExerciciosOO;
using System.Runtime.CompilerServices;

public class Exercicios
{
    public static void Main()
    {

        Pessoa p = new Pessoa();

        p.Cadastrar();
        p.Apresentar();

        

        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Matricula: ");
        string matricula = Console.ReadLine();
        Console.WriteLine("Turma: ");
        int turma = int.Parse(Console.ReadLine());

        Aluno a = new Aluno(nome, matricula, turma);
        Console.WriteLine($"{a.nome}, {a.matricula}, {a.turma}");

        

        Personagem player = new Personagem("Alisson", 0, 0);
        player.Atacar(7.5);
        player.Movimentar(4);

        

        Livro l1 = new Livro("A", "Terror", 1970);
        Livro l2 = new Livro("B", "Romance", 1970);
        Livro l3 = new Livro("C", "Ficção", 1970);

        l1.emprestar();
        l2.devolver();
        l1.emprestar();
        l1.devolver();
    }
}