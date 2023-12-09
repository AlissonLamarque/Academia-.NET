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
    public partial class Form_3 : Form
    {
        public Form_3()
        {
            InitializeComponent();
        }

        private void button_SairAmigoSecreto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_GerarAmigoSecreto_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                List<Pessoa> lista = form1.listaAmigo;
                List<Pessoa> listaSecreta = form1.listaAmigoSecreto;

                if (lista.Count <= 2)
                {
                    MessageBox.Show($"Não é possível gerar Amigos Secretos com {lista.Count} amigos!", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult resposta = DialogResult.Yes;
                    bool gerarValido = true;

                    if (listaSecreta.Count != 0)
                    {
                        resposta = MessageBox.Show("Deseja gerar novamente a lista de Amigos Secretos?", "Gerar Amigos Secretos novamente", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resposta == DialogResult.No) gerarValido = false;

                    }

                    if (gerarValido)
                    {
                            MessageBox.Show("Gerando arquivo com Amigos Secretos", "", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            form1.listaAmigoSecreto = Comunicacao.gerarAmigoSecreto(lista);
                            listaSecreta = form1.listaAmigoSecreto;

                            if (form1.listaAmigoSecreto != null) MessageBox.Show("Lista de Amigos Secretos gerada!", "Sucesso", 
                                MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void button_ListarAmigoSecreto_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            DialogResult resposta;

            if (form1.listaAmigoSecreto.Count() != 0)
            {
                resposta = MessageBox.Show("Deseja revelar os Amigos Secretos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                { 
                    if (form1 != null)
                    {
                        List<Pessoa> lista = form1.listaAmigo;
                        List<Pessoa> listaSecreta = form1.listaAmigoSecreto;

                        listView_AmigoSecreto.Items.Clear();

                        for (int i = 0; i < Math.Max(lista.Count, listaSecreta.Count); i++)
                        {
                            string[] items = new string[4];

                            if (i < lista.Count)
                            {
                                items[0] = lista[i].Nome;
                                items[1] = lista[i].Email;
                            }

                            if (i < listaSecreta.Count)
                            {
                                items[2] = listaSecreta[i].Nome;
                                items[3] = listaSecreta[i].Email;
                            }

                            listView_AmigoSecreto.Items.Add(new ListViewItem(items));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Gere a lista de Amigos Secretos para listar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
