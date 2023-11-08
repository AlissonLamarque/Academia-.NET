/*
2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar um método abstrato chamado Dirigir. Criar duas classes derivadas, 
Carro e Moto, que herdam de Veiculo. 
A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
Criar um método abstrato Dirigir na classe Veiculo. 
Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método 
Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"
 */

using Exercicio02;

public class Program
{
    public static void Main()
    {
        Carro carro = new Carro();
        Moto moto = new Moto();

        carro.marca = "Honda";
        carro.modelo = "Fit";
        carro.qtdPortas = 4;

        moto.marca = "Honda";
        moto.modelo = "Biz";
        moto.cilindrada = 124;

        carro.Dirigir();
        moto.Dirigir();
    }
}