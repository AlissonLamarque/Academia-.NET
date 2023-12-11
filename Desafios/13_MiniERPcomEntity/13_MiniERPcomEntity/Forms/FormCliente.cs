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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text.ToUpper();
            string email = textBox_Email.Text.ToLower();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nome inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(email) || !Operacoes.EmailIsValid(email))
            {
                MessageBox.Show("E-mail inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Operacoes.VerificaDuplicidade(email, 2))
                {
                    try
                    {
                        Operacoes.CadastrarCliente(nome, email);
                        DialogResult resposta = MessageBox.Show("Deseja cadastrar mais clientes?", "Sucesso",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.No)
                            this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro durante o cadastro de cliente", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Cliente já cadastrado", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
