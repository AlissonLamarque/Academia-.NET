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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
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

        private void textBox_Cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas números, '.' e '/'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '/' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text.ToUpper();
            string cnpj = textBox_Cnpj.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nome inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cnpj) || cnpj.Length < 14)
            {
                MessageBox.Show("CNPJ inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Operacoes.VerificaDuplicidade(cnpj, 3))
                {
                    try
                    {
                        Operacoes.CadastrarFornecedor(nome, cnpj);
                        DialogResult resposta = MessageBox.Show("Deseja cadastrar mais fornecedores?", "Sucesso",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.No)
                            this.Close();
                    }
                    catch (Exception) 
                    {
                        MessageBox.Show("Erro durante o cadastro de fornecedor", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Fornecedor já cadastrado", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
