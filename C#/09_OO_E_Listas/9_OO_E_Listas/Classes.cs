using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OO_E_Listas
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

        public void adicionarProduto(int quantEstoque)
        {
            quantEstoque++;
            Console.WriteLine("Produto adicionado com sucesso!");
        }
        public void removerProduto(int quantEstoque)
        {
            if (quantEstoque > 0)
            {
                quantEstoque--;
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Sem estoque do produto indicado.");
            }
        }
    }

    internal class RegistroDeCompras
    {
        public string data;
        public string produto;
        public double valor;

        public RegistroDeCompras(string data, string produto, double valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
        }

        public void adicionarCompras(List<RegistroDeCompras> lista)
        {
            
        }

        public void listarCompras(List<RegistroDeCompras> lista)
        {
        }
    }
}
