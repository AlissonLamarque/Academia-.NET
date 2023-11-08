using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtdEstoque { get; set; }

        public Produto(string nome)
        {
            this.nome = nome;
        }

        public Produto(string nome, double preco, int qtdEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtdEstoque = qtdEstoque;
        }
    }
}
