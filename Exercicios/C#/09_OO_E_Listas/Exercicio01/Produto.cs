using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantEstoque;

        public Produto(string nome, double preco, int quantEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantEstoque = quantEstoque;
        }

        public void adicionarProduto(int qtdProduto)
        {
            if (qtdProduto > 0)
            {
                quantEstoque += qtdProduto;
                Console.WriteLine("Produto adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não é possível adicionar 0 produtos!");
            }
        }
        public void removerProduto(int qtdProduto)
        {
            if (quantEstoque > 0 && quantEstoque > qtdProduto)
            {
                quantEstoque -= qtdProduto;
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Sem estoque do produto indicado ou tentativa de remoção maior do que presente no estoque.");
            }
        }
    }
}
