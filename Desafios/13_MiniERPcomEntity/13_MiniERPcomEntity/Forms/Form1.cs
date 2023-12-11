using _13_MiniERPcomEntity.Forms;

namespace _13_MiniERPcomEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Operacoes.ListarBd(listView_Lista);
        }

        private void button_Produto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }

        private void button_Cliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void button_Fornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.Show();
        }

        private void button_Compra_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }

        private void button_Notas_Click(object sender, EventArgs e)
        {
            FormListaNotas formNotas = new FormListaNotas();
            formNotas.Show();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Listar_Click(object sender, EventArgs e)
        {
            Operacoes.ListarBd(listView_Lista);
        }
    }
}