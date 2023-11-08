/*
3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo" 
calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo. 
 */

using Exercicio03;

public class Program
{
    public static void Main()
    {
        Circulo circulo = new Circulo();
        Retangulo retangulo = new Retangulo();

        circulo.raio = 2.5;
        retangulo.lado1 = 2;
        retangulo.lado2 = 3;

        retangulo.CalcularPerimetro();
        retangulo.CalcularArea();

        circulo.CalcularPerimetro();
        circulo.CalcularArea();
    }
}