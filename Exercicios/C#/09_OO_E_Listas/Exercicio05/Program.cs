using Exercicio05;

public class Program
{
    public static void Main()
    {
        string descricao, dataVencimento;
        int op;
        GerenciadorDeTarefas tarefa = new GerenciadorDeTarefas("", "");

        do
        {
            Console.Clear();
            Console.WriteLine("--- Gerenciador de Tarefas ---");
            Console.WriteLine("1 - Adicionar tarefa\n2 - Remover tarefa\n3 - Listar tarefas\n4 - Sair");
            Console.Write("--- Sua opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Nome: ");
                    descricao = Console.ReadLine();
                    Console.WriteLine("Data de vencimento (dd/mm): ");
                    dataVencimento = Console.ReadLine();
                    tarefa.adicionarTarefa(descricao, dataVencimento);
                    break;
                case 2:
                    Console.WriteLine("Nome: ");
                    descricao = Console.ReadLine();
                    Console.WriteLine("Data de vencimento (dd/mm): ");
                    dataVencimento = Console.ReadLine();
                    tarefa.removerTarefa(descricao, dataVencimento);
                    break;
                case 3:
                    tarefa.listarTarefas();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Obrigado pela preferência! Saindo do sistema...");
                    break;
            }
        } while (op != 4);
    }
}