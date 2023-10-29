using _9_OO_E_Listas;

public class Lista09
{
    public static void Main()
    {
        /*
        Produto p1 = new Produto("p1", 59.99, 0);
        Produto p2 = new Produto("p2", 12.50, 0);

        p1.adicionarProduto(p1.quantEstoque);
        p2.removerProduto(p2.quantEstoque);
        p1.removerProduto(p1.quantEstoque);
        */


        Console.WriteLine("Data da compra (DD/MM/AA): ");
        string data = Console.ReadLine();
        Console.WriteLine("Nome do produto: ");
        string produto = Console.ReadLine();
        Console.WriteLine("Valor da compra: ");
        double valor = double.Parse(Console.ReadLine());

        List<RegistroDeCompras> ListaCompras = new List<RegistroDeCompras>();
        RegistroDeCompras r1 = new RegistroDeCompras(data, produto, valor);
        r1.adicionarCompras(ListaCompras);
    }
}
