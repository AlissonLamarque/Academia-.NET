namespace TestandoDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.WriteLine("Sistema de pedidos");
                Console.Write("1 - Cadastrar Cliente\n2 - Visualizar Clientes\n3 - Cadastrar Pedidos\n4 - Visualizar Pedidos\n0 - Sair do sistema\nSua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    case 1:
                        inserirCliente();
                        break;
                    case 2:
                        mostrarTodosClientes();
                        break;
                    case 3:
                        inserirPedido();
                        break;
                    case 4:
                        mostrarTodosPedidos();
                        break;
                    default:
                        Console.WriteLine("Digite uma operação válida");
                        break;
                }
            } while (op != 0);
        }

        private static void inserirCliente() {
            using (var contexto = new BancoContext())
            {
                Cliente c = new Cliente();
                Console.WriteLine("Digite o nome do cliente: ");
                c.Nome = Console.ReadLine();
                Console.WriteLine("Digite o email do cliente: ");
                c.Email = Console.ReadLine();
                contexto.Clientes.Add(c);
                contexto.SaveChanges();
                Console.WriteLine("Cliente inserido com sucesso!");
            }
        }

        private static void mostrarTodosClientes()
        {
            using (var contexto = new BancoContext())
            {
                var clientes = contexto.Clientes.ToList();

                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"Cliente: {cliente.Id} Nome: {cliente.Nome} Email: {cliente.Email}");
                }
            }
        }

        private static void inserirPedido()
        {
            using (var contexto = new BancoContext())
            {
                Pedido p = new Pedido();
                Console.WriteLine("Digite o ID do cliente: ");
                p.IdCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a data do pedido - formato AAAA-MM-DD");
                p.Datapedido = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do pedido: ");
                p.Valor = (decimal?)double.Parse(Console.ReadLine());
                contexto.Pedidos.Add(p);
                contexto.SaveChanges();
                Console.WriteLine("Pedido inserido com sucesso!");
            }
        }

        private static void mostrarTodosPedidos()
        {
            using (var contexto = new BancoContext())
            {
                var pedidos = contexto.Pedidos.ToList();

                foreach (var pedido in pedidos)
                {
                    Console.WriteLine($"Pedido: {pedido.Id} Valor: {pedido.Valor} Data: {pedido.Datapedido}");
                }
            }
        }
    }

}