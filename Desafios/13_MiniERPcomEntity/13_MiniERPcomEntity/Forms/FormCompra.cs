using _13_MiniERPcomEntity.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_MiniERPcomEntity.Forms
{
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
            listarProdutoCliente();
        }

        private void button_Pronto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Realizar_Click(object sender, EventArgs e)
        {
            decimal idProduto = numericUpDown_Produto.Value;
            decimal idCliente = numericUpDown_Cliente.Value;

            if (idProduto == 0 || idCliente == 0)
            {
                MessageBox.Show("Valor inválido");
            }
            else
            {
                MessageBox.Show("Sucesso");
            }
        }

        private void listarProdutoCliente()
        {
            listView_Compra.Items.Clear();
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();
                var clientes = contexto.Clientes.ToList();

                int menorLista = Math.Min(produtos.Count, clientes.Count);

                for (int i = 0; i < menorLista; i++)
                {
                    string[] item = { produtos[i].Nome, clientes[i].Nome };
                    listView_Compra.Items.Add(new ListViewItem(item));
                }

                for (int i = menorLista; i < produtos.Count; i++)
                {
                    string[] item = { produtos[i].Nome };
                    listView_Compra.Items.Add(new ListViewItem(item));
                }

                for (int i = menorLista; i < clientes.Count; i++)
                {
                    string[] item = { clientes[i].Nome };
                    listView_Compra.Items.Add(new ListViewItem(item));
                }
            }
        }
    }
}
