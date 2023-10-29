using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Pessoa
    {
        public string nome;
        public string cpf;
        public string dataNasc;
        public string rg;

        public void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Data de nascimento (DD/MM/AAAA): ");
            dataNasc = Console.ReadLine();
            Console.WriteLine("RG: ");
            rg = Console.ReadLine();
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}\nCPF: {cpf}\nData de Nascimento: {dataNasc}\nRG: {rg}");
        }
    }

    internal class Aluno
    {
        public string nome;
        public string matricula;
        public int turma;

        public Aluno(string nome, string matricula, int turma)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.turma = turma;
        }
    }

    internal class Personagem
    {
        public string nome;
        public double pos;
        public int itensColetados;

        public Personagem(string nome, double pos, int itensColetados)
        {
            this.nome = nome;
            this.pos = pos;
            this.itensColetados = itensColetados;
        }

        public void Atacar(double dano)
        {
            Console.WriteLine($"Dano: {dano}");
        }

        public void Movimentar(int movimento)
        {
            if (movimento == 1)
            {
                Console.WriteLine("Movimento: Frente");
            }
            if (movimento == 2)
            {
                Console.WriteLine("Movimento: Traz");
            }
            if (movimento == 3)
            {
                Console.WriteLine("Movimento: Esquerda");
            }
            if (movimento == 4)
            {
                Console.WriteLine("Movimento: Direita");
            }
        }
    }

    internal class Livro
    {
        public string titulo;
        public string genero;
        public int anoDePublicacao;
        public bool emprestado = false;

        public Livro(string titulo, string genero, int anoDePublicacao)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.anoDePublicacao = anoDePublicacao;
        }

        public void emprestar()
        {
            if (!emprestado)
            {
                emprestado = true;
                Console.WriteLine("O livro foi emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("O livro já esta emprestado.");
            }
        }

        public void devolver()
        {
            if (emprestado)
            {
                emprestado = false;
                Console.WriteLine("O livro foi devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("O livro não foi emprestado.");
            }
        }
    }
}
