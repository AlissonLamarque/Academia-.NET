namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colocarListaTextBox(List<Pessoa> Lista)
        {
            listView_pessoas.Items.Clear();

            foreach (Pessoa p in Lista)
            {
                string[] items = { p.Nome, p.Email };

                listView_pessoas.Items.Add(new ListViewItem(items));
            }
        }

        private void textBox_frase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string[] vetor = textBox_frase.Text.Split();
                if (vetor.Length >= 2)
                {
                    //gerar o email

                    string nome = textBox_frase.Text.ToUpper();

                    Pessoa p = new Pessoa(nome);

                    //Verificar se p já existe
                    if (!lista.Contains(p))
                    {
                        lista.Add(p);
                        lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));


                        //Adicionar

                        colocarListaTextBox(lista);
                        textBox_frase.Text = string.Empty;
                    }
                }

                else
                {
                    MessageBox.Show("Nome inválido!");
                }
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            textBox_relacaoNomes.Clear();
        }

        List<Pessoa> lista = new List<Pessoa>();
    }
}