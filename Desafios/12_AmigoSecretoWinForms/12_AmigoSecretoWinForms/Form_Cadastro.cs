using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _12_AmigoSecretoWinForms
{
    public partial class Form_2 : Form
    {
        public Form_2()
        {
            InitializeComponent();
        }

        private void button_SairCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            label_NomeInvalido.Visible = false;

            if (e.KeyChar == (char)Keys.Enter)
            {
                string nome = textBox_Nome.Text;

                if (string.IsNullOrEmpty(nome))
                    label_NomeInvalido.Visible = true;
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            string email = textBox_Email.Text;

            label_EmailInvalido.Visible = false;

            if (!Utilidades.EmailIsValid(email))
                label_EmailInvalido.Visible = true;
        }

        private void button_EnviarCadastro_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text.ToUpper();
            string email = textBox_Email.Text.ToLower();

            if (!string.IsNullOrEmpty(nome))
            {
                if (Utilidades.EmailIsValid(email))
                {
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;

                    if (form1 != null)
                    {
                        List<Pessoa> lista = form1.listaAmigo;
                        Comunicacao.cadastrarPessoa(lista, nome, email);
                        Comunicacao.listarPessoas(lista, listView_Amigos);
                    }
                }
                else
                    MessageBox.Show("Email Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Nome Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_LimparLista_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja apagar todos cadastros", "Limpar Lista de Amigos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Form1 form1 = Application.OpenForms["Form1"] as Form1;

                if (form1 != null)
                {
                    List<Pessoa> lista = form1.listaAmigo;
                    if (lista.Count != 0)
                    {
                        lista.Clear();
                        listView_Amigos.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sem cadastros para limpar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form_2_Load(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                List<Pessoa> lista = form1.listaAmigo;
                Comunicacao.listarPessoas(lista, listView_Amigos);
            }
        }
    }
}
