using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }
}
