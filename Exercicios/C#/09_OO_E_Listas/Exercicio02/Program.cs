using Exercicio02;

public class Exercicio2
{
    public static void Main()
    {
        string data, produto;
        double valor;

        Console.WriteLine("Data da compra: ");
        data = Console.ReadLine();
        Console.WriteLine("Produto: ");
        produto = Console.ReadLine();
        Console.WriteLine("Valor: ");
        valor = double.Parse(Console.ReadLine());

        RegistroDeCompras novaCompra = new RegistroDeCompras(data, produto, valor);

        novaCompra.ListarCompras();
    }
}