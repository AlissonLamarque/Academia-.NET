using System;
using System.Windows.Forms;

namespace _12_AmigoSecretoWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Persistencia.popularArquivoLista("amigoSecreto.csv", listaAmigo);
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Form_2 formCadastro = new Form_2();
            formCadastro.Show();
        }

        private void button_Gerar_Click(object sender, EventArgs e)
        {
            Form_3 formAmigoSecreto = new Form_3();
            formAmigoSecreto.Show();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("      Obrigado pela preferência\n            Saindo do sistema...");
            Thread.Sleep(500);
            Application.Exit();
        }

        private List<Pessoa> listaAmigos = new List<Pessoa>();

        public List<Pessoa> listaAmigo
        {
            get { return listaAmigos; }
            set { listaAmigos = value; }
        }

        private List<Pessoa> listaAmigosSecretos = new List<Pessoa>();

        public List<Pessoa> listaAmigoSecreto
        {
            get { return listaAmigosSecretos; }
            set { listaAmigosSecretos = value; }
        }
    }
}