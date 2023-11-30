using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WF_MiniERP.DataModel;

namespace WF_MiniERP
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

        public static bool CadastrarProduto(string nome, string desc, decimal valor, int fornecedor)
        {
            using (var contexto = new MiniErpContext())
            {
                Produto p = new Produto();
                p.Nome = nome;
                p.Descricao = desc;
                p.Valor = valor;
                p.FkFornecedor = fornecedor;
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
                contexto.Fornecedores.Add(f);
                contexto.SaveChanges();
                return true;
            }
        }
    }
}
