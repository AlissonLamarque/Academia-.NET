using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_MiniERP.DataModel;

namespace WF_MiniERP.Formulários
{
    public partial class Form_Compra : Form
    {
        public Form_Compra()
        {
            InitializeComponent();
        }

        private void button_Pronto_Click(object sender, EventArgs e)
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
                this.Close();
            }
        }
    }
}
