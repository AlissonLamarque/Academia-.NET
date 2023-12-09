using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AmigoSecretoWinForms
{
    internal class Persistencia
    {
        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                Pessoa tmp;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    tmp = new Pessoa(vetorLinha[0], vetorLinha[1]);
                    if (!lista.Contains(tmp))
                        lista.Add(tmp);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void gravarSimples(Pessoa p, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(p.Nome + ";" + p.Email);

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void gerarArquivoAmigoSecreto(List<Pessoa> lista, List<Pessoa> listaTmp)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("secreto.csv");

                for (int i = 0; i < lista.Count; i++)
                {
                    escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaTmp[i].Nome + ";" + listaTmp[i].Email);
                }

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }
    }
}
