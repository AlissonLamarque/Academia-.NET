//1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.  
//A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.  
//Criar um método abstrato Apresentar na classe Pessoa. 
//Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe
//Professor que imprime o nome, a idade e a disciplina do professor.

using Exercicio01;

public class Program
{
    public static void Main()
    {
        Professor professor = new Professor();
        Aluno aluno = new Aluno();

        aluno.nome = "Alisson";
        aluno.idade = 20;
        aluno.matricula = "Academia .NET";

        professor.nome = "Carlos";
        professor.idade = 40;
        professor.disciplina = "Abstração em POO";

        aluno.Apresentar();
        professor.Apresentar();
    }
}