using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class GerenciadorDeTarefas
    {
        static List<GerenciadorDeTarefas> listaTarefas = new List<GerenciadorDeTarefas> ();

        public string descricao { get; set; }
        public string dataVencimento { get; set; }

        public GerenciadorDeTarefas(string descricao, string dataVencimento)
        {
            this.descricao = descricao;
            this.dataVencimento = dataVencimento;
        }

        public void adicionarTarefa(string descricao, string dataVencimento)
        {
            GerenciadorDeTarefas tarefa = new GerenciadorDeTarefas(descricao, dataVencimento);
            listaTarefas.Add(tarefa);
        }

        public void removerTarefa(string descricao, string dataVencimento)
        {
            bool tarefaExiste = false;
            foreach (var item in listaTarefas)
            {
                if (item.descricao == descricao && item.dataVencimento == dataVencimento)
                {
                    listaTarefas.Remove(item);
                    tarefaExiste = true;
                    break;
                }
            }
            if (!tarefaExiste)
            {
                Console.WriteLine("Tarefa não foi encontrada");
            }
        }

        public void listarTarefas()
        {
            DateTime data = DateTime.Today;

            foreach (GerenciadorDeTarefas tarefa in listaTarefas)
            {
                string[] vetor = tarefa.dataVencimento.Split('/');
                int dia = int.Parse(vetor[0]);
                int mes = int.Parse(vetor[1]);

                Console.Write($"\n{tarefa.descricao} - {tarefa.dataVencimento}");
                
                if (dia == data.Day && mes == data.Month)
                {
                    Console.Write(" (HOJE)");
                }
            }
        }
    }
}
