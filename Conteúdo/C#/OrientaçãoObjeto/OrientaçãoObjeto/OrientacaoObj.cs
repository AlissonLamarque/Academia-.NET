using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoObjeto
{

    internal class Pessoa
    {
        public string nome;
        public int idade;
    }
    internal class Professor
    {
        public string nome;
    }

    internal class Laboratorio
    {
        public string local;
    }

    internal class Pessoa2
    {
        public string nome;
        public int idade;
        public string genero;
    }

    internal class Jogo
    {
        public string titulo;
        public string genero;
        public string plataforma;
        public int anoDeLancamento;
    }

    internal class Estudio
    {
        public string nome;
        public int anoDeFundacao;
        public string paisDeOrigem;
        public int NrDeJogosProduzidos;
    }

    internal class Carro
    {
        public string marca;
        public string modelo;
        public int anoDeFabricacao;
    }

    internal class Livro
    {
        public string titulo;
        public string autor;
        public int anoDePublicacao;
    }
}
