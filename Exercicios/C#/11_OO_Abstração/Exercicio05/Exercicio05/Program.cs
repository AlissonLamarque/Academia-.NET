/*
5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto". 
Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método 
"CalcularDesconto" de acordo com as regras específicas de desconto para cada tipo de produto.
Livro – 5% de desconto
Eletrônico  - 12.5% de desconto
 */

using Exercicio05;

public class Program
{
    public static void Main()
    {
        Livro livro = new Livro();
        Eletronico eletronico = new Eletronico();

        livro.nome = "livro";
        livro.preco = 45.50;
        livro.CalcularDesconto();

        eletronico.nome = "eletronico";
        eletronico.preco = 39.99;
        eletronico.CalcularDesconto();
        
    }
}