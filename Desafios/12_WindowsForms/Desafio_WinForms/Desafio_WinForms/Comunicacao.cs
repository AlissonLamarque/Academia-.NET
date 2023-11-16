using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_WinForms
{
    internal class Comunicacao
    {
        public static void cadastrarPessoa(List<Pessoa> lista)
        {
            string nome, email;

            do
            {
                Console.WriteLine("Informe um email válido: ");
                email = Console.ReadLine();
            } while (!Utilidades.EmailIsValid(email));

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine().ToUpper();

            Pessoa pessoa = new Pessoa(nome, email);

            if (lista.Contains(pessoa))
            {
                Console.WriteLine("Email já está em uso!");
            }
            else
            {
                lista.Add(pessoa);
                lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                Persistencia.gravarSimples(pessoa, "amigos.csv");
            }
        }

        public static void listarPessoas(List<Pessoa> lista)
        {
            foreach (var pessoa in lista)
            {
                Console.WriteLine(pessoa);
            }
        }

        public static void gerarAmigoSecreto(List<Pessoa> lista)
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
                    if (lista[i] == listaTmp[i])
                    {
                        deuCerto = false;
                        listaTmp.Clear();
                        listaTmp.AddRange(lista);
                    }
                }
            } while (!deuCerto);

            Persistencia.gerarArquivoAmigoSecreto(lista, listaTmp);
        }
    }
}
