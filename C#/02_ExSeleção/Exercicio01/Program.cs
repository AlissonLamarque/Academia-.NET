/* 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero.  */

public class Exercicio01
{
    public static void Main()
    {
        do
        {
            Console.WriteLine("Altura do triângulo: ");
            int alturaT = int.Parse(Console.ReadLine());

            Console.WriteLine("Base do triângulo: ");
            int baseT = int.Parse(Console.ReadLine());

            if( alturaT == 0 || baseT == 0)
            {
                Console.WriteLine("Altura ou base inválida!");
            }
            else
            {
                float areaT = (baseT * alturaT) / 2;
                Console.WriteLine($"A área do triângulo é igual a: {areaT}");
                break;
            }
        } while (true);
    }
}