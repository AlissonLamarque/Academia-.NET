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
    public partial class FormListaNotas : Form
    {
        public FormListaNotas()
        {
            InitializeComponent();
            Operacoes.ListarNota(listView_Notas);
        }

        private void button_Pronto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
