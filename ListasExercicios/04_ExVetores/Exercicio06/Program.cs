/* 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. 
Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|22|7|31|63|0|21|9|3|40|7| */

public class Exercicio06
{
    public static void Main(string[] args)
    {
        int[] vetor = new int[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor para a {i + 1}º posição do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write($" |{vetor[i]}| ");
        }
    }
}