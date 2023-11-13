using Exercicio02;

public class Exercicio2
{
    public static void Main()
    {
        string data, produto;
        char opcao;
        double valor;

        do
        {
            Console.Clear();
            Console.WriteLine("Data da compra: ");
            data = Console.ReadLine();
            Console.WriteLine("Produto: ");
            produto = Console.ReadLine();
            Console.WriteLine("Valor: ");
            valor = double.Parse(Console.ReadLine());

            RegistroDeCompras novaCompra = new RegistroDeCompras(data, produto, valor);
            novaCompra.AdicionarCompras();

            novaCompra.ListarCompras();

            Console.WriteLine("Deseja registrar mais compras (s/n): ");
            opcao = char.Parse(Console.ReadLine());
        } while (opcao == 's');
    }
}