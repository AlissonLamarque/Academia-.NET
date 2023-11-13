using Exercicio04;

public class Program
{
    public static void Main()
    {
        string nome, email, telefone;
        int op;
        AgendaTelefonica agendaTelefonica = new AgendaTelefonica("", "", "");

        do
        {
            Console.Clear();
            Console.WriteLine("--- Agenda Telefônica ---");
            Console.WriteLine("1 - Armazenar contato\n2 - Remover contato\n3 - Buscar contato\n4 - Listar contatos\n5 - Sair");
            Console.Write("Sua opção: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    telefone = Console.ReadLine();
                    agendaTelefonica.armazenarContato(nome, email, telefone);
                    break;
                case 2:
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    telefone = Console.ReadLine();
                    agendaTelefonica.removerContato(nome, telefone);
                    break;
                case 3:
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    agendaTelefonica.buscarContato(nome);
                    Console.ReadKey();
                    break;
                case 4:
                    agendaTelefonica.listarContato();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Obrigado pela preferência! Saindo do sistema...");
                    break;
            }
        } while (op != 5);
    }
}