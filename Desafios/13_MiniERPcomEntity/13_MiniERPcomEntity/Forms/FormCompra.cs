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
            Operacoes.ListarProdutoCliente(listView_Compra);
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
                try
                {
                    Operacoes.RealizarCompra(idProduto, idCliente);
                    DialogResult resposta = MessageBox.Show("Deseja realizar mais compras?", "Sucesso",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.No)
                        this.Close();
                    else
                        Operacoes.ListarProdutoCliente(listView_Compra);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na realização de compra", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
