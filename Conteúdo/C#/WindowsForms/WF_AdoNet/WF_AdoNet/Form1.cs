using System.Data;

namespace WF_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();

            btn.Name = "btnDinamico";
            btn.Text = "Botão Dinâmico";
            btn.Size = new System.Drawing.Size(152, 23);

            panel1.Controls.Add(btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.nome = textBox2.Text;
            p.idade = int.Parse(textBox3.Text);

            if (p.gravar())
            {
                MessageBox.Show("Cadastrado com sucesso!");

                button2_Click(null, null);
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar");
            }
        }
    }
}