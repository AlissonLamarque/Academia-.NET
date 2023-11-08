using Exercicio01;

public class Exercicio1
{
    public static void Main()
    {
        Produto p1 = new Produto("p1", 59.99, 0);
        Produto p2 = new Produto("p2", 12.50, 0);

        
        Console.WriteLine($"Estoque p1: {p1.quantEstoque} p2: {p2.quantEstoque}");
        p1.adicionarProduto(30);
        Console.WriteLine($"Estoque p1: {p1.quantEstoque} p2: {p2.quantEstoque}");
        p2.removerProduto(2);
        Console.WriteLine($"Estoque p1: {p1.quantEstoque} p2: {p2.quantEstoque}");
        p1.removerProduto(45);
        Console.WriteLine($"Estoque p1: {p1.quantEstoque} p2: {p2.quantEstoque}");
        p1.removerProduto(15);
        Console.WriteLine($"Estoque p1: {p1.quantEstoque} p2: {p2.quantEstoque}");
    }
}