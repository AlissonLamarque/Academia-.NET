﻿using System;
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
    public partial class FormProduto : Form
    {
        public FormProduto()
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

        private void textBox_Desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void textBox_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas números, '.' e ','
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void button_Fornecedores_Click(object sender, EventArgs e)
        {
            FormListaFornecedor form = new FormListaFornecedor();
            form.Show();
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text.ToUpper();
            string desc = textBox_Desc.Text.ToLower();
            string valortmp = textBox_Valor.Text;
            decimal valor = 0;
            decimal fornecedor = numericUpDown_Fornecedor.Value;


            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nome inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Descrição inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(valortmp))
            {
                MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fornecedor == 0)
            {
                MessageBox.Show("Fornecedor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Operacoes.VerificaDuplicidade(nome, 1)) 
                {
                    try
                    {
                        valor = decimal.Parse(valortmp);
                        Operacoes.CadastrarProduto(nome, desc, valor, fornecedor);
                        DialogResult resposta = MessageBox.Show("Deseja cadastrar mais produtos?", "Sucesso",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.No)
                            this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro no cadastro de produto", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Produto já cadastrado", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
