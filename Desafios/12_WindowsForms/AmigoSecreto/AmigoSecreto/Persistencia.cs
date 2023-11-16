using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    internal class Persistencia
    {
        public static void lerArquivoParaTela(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    Console.WriteLine(leitor.ReadLine());
                } while (!leitor.EndOfStream);
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void lerArquivoExibeNome(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    Console.WriteLine(vetorLinha[0]);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader (nomeArquivo, Encoding.UTF8);
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

        public static void exibirLista(List<Pessoa> lista)
        {
            foreach(var item in lista)
                Console.WriteLine(item);
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo);

                foreach(var item in lista)
                {
                    escritor.WriteLine(item.Nome + ";" + item.Email);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void atualizarPessoaArquivo(Pessoa pessoa, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email);

                escritor.Close();
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
