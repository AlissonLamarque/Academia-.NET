using _13_MiniERPcomEntity.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13_MiniERPcomEntity
{
    internal class Operacoes
    {
        
        public static bool EmailIsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";

            return Regex.IsMatch(email, pattern);
        }
        
        public static bool CadastrarProduto(string nome, string desc, decimal valor, decimal fornecedor)
        {
            using (var contexto = new MiniErpContext())
            {
                Produto p = new Produto();
                p.Nome = nome;
                p.Descricao = desc;
                p.Valor = valor;
                p.FkFornecedor = (int?)fornecedor;
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
                return true;
            }
        }

        public static bool CadastrarCliente(string nome, string email)
        {
            using (var contexto = new MiniErpContext())
            {
                Cliente c = new Cliente();
                c.Nome = nome;
                c.Email = email;
                contexto.Clientes.Add(c);
                contexto.SaveChanges();
                return true;
            }
        }

        public static bool CadastrarFornecedor(string nome, string cnpj)
        {
            using (var contexto = new MiniErpContext())
            {
                Fornecedor f = new Fornecedor();
                f.Nome = nome;
                f.Cnpj = cnpj;
                contexto.Fornecedors.Add(f);
                contexto.SaveChanges();
                return true;
            }
        }

        public static bool RealizarCompra(decimal produto, decimal cliente)
        {
            using (var contexto = new MiniErpContext())
            {
                Notum n = new Notum();
                n.FkCliente = (int?) cliente;
                n.FkProduto = (int?) produto;
                contexto.Nota.Add(n);
                contexto.SaveChanges();
                return true;
            }
        }

        public static void ListarBd(ListView lista)
        {
            lista.Items.Clear();

            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();
                var clientes = contexto.Clientes.ToList();
                var fornecedores = contexto.Fornecedors.ToList();

                int maiorLista = Math.Max(produtos.Count, Math.Max(clientes.Count, fornecedores.Count));

                for (int i = 0; i < maiorLista; i++)
                {
                    string[] item = 
                    {
                        i < produtos.Count ? produtos[i].Nome : "",
                        i < clientes.Count ? clientes[i].Nome : "",
                        i < fornecedores.Count ? fornecedores[i].Nome : ""
                    };

                    lista.Items.Add(new ListViewItem(item));
                }
            }
        }

        public static void ListarProdutoCliente(ListView lista)
        {
            lista.Items.Clear();
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();
                var clientes = contexto.Clientes.ToList();

                int menorLista = Math.Min(produtos.Count, clientes.Count);

                for (int i = 0; i < menorLista; i++)
                {
                    string[] item = { produtos[i].Id.ToString(), produtos[i].Nome, clientes[i].Id.ToString(), clientes[i].Nome };
                    lista.Items.Add(new ListViewItem(item));
                }

                for (int i = menorLista; i < produtos.Count; i++)
                {
                    string[] item = { produtos[i].Id.ToString(), produtos[i].Nome };
                    lista.Items.Add(new ListViewItem(item));
                }

                for (int i = menorLista; i < clientes.Count; i++)
                {
                    string[] item = { clientes[i].Id.ToString(), clientes[i].Nome };
                    lista.Items.Add(new ListViewItem(item));
                }
            }
        }

        public static void ListarFornecedores(ListView lista)
        {
            lista.Items.Clear();
            using (var contexto = new MiniErpContext())
            {
                var fornecedores = contexto.Fornecedors.ToList();

                foreach(var f in fornecedores)
                {
                    string[] item = { f.Id.ToString(), f.Nome };
                    lista.Items.Add(new ListViewItem(item));
                }
            }
        }

        public static void ListarNota(ListView lista)
        {
            lista.Items.Clear();
            using (var contexto = new MiniErpContext())
            {
                var notas = contexto.Nota.ToList();
                var produtos = contexto.Produtos.ToList();
                var clientes = contexto.Clientes.ToList();

                for (int i = 0; i < notas.Count; i++)
                {
                    string[] item = { notas[i].Id.ToString(), produtos[i].Nome, clientes[i].Nome };
                    lista.Items.Add(new ListViewItem(item));
                }
            }
        }
    }
}
