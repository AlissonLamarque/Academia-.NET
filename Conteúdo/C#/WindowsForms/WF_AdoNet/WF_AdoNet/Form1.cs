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
            DataTable dt = new DataTable();
            Pessoa p = new Pessoa();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                dt = p.buscaPessoas();
            }
            else
            {
                p.id = int.Parse(textBox1.Text);
                dt = p.buscaPessoasById();
            }


            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Pessoa p = new Pessoa();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                dt = p.buscaPessoas();
            }
            else
            {
                p.id = int.Parse(textBox1.Text);
                //p = p.buscaPessoaByIdDR();
                //MessageBox.Show(p.nome);
                dt = p.buscaPessoasById();
            }


            dataGridView1.DataSource = dt;
        }
    }
}