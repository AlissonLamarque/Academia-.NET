using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AmigoSecretoWinForms
{
    internal class Comunicacao
    {
        public static void cadastrarPessoa(List<Pessoa> lista, string nome, string email)
        {
            Pessoa pessoa = new Pessoa(nome, email);

            if (VerificarDuplicidade(lista, pessoa))
            {
                MessageBox.Show("Email já está em uso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lista.Add(pessoa);
                lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                //Persistencia.gravarSimples(pessoa, "amigos.csv");
            }
        }

        private static bool VerificarDuplicidade(List<Pessoa> lista, Pessoa pessoa)
        {
            foreach (Pessoa p in lista)
            {
                if (p.Email == pessoa.Email)
                {
                    return true;
                }
            }
            return false;
        }

        public static void listarPessoas(List<Pessoa> lista, ListView Listar)
        {
            Listar.Items.Clear();

            foreach (Pessoa p in lista)
            {
                string[] items = { p.Nome, p.Email };

                Listar.Items.Add(new ListViewItem(items));
            }
        }

        public static List<Pessoa> gerarAmigoSecreto(List<Pessoa> lista)
        {
            List<Pessoa> listaTmp = new List<Pessoa>();
            listaTmp.AddRange(lista);

            bool deuCerto;

            do
            {
                deuCerto = true;
                listaTmp = listaTmp.OrderBy(x => Random.Shared.Next()).ToList();

                for (int i = 0; i < listaTmp.Count; i++)
                {
                    if (lista[i].Email == listaTmp[i].Email)
                    {
                        deuCerto = false;
                        listaTmp.Clear();
                        listaTmp.AddRange(lista);
                    }
                }
            } while (!deuCerto);

            //Persistencia.gerarArquivoAmigoSecreto(lista, listaTmp);
            return listaTmp;
        }
    }
}
