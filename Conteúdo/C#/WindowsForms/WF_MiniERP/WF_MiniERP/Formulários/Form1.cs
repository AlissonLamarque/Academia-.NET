using WF_MiniERP.Formulários;
using WF_MiniERP.DataModel;

namespace WF_MiniERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CadastroProduto_Click(object sender, EventArgs e)
        {
            Form_Produto formProduto = new Form_Produto();
            formProduto.Show();
        }

        private void button_CadastroCliente_Click(object sender, EventArgs e)
        {
            Form_Cliente formCliente = new Form_Cliente();
            formCliente.Show();
        }

        private void button_CadastroFornecedor_Click(object sender, EventArgs e)
        {
            Form_Fornecedor formFornecedor = new Form_Fornecedor();
            formFornecedor.Show();
        }

        private void button_Compra_Click(object sender, EventArgs e)
        {
            Form_Compra formCompra = new Form_Compra();
            formCompra.Show();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}