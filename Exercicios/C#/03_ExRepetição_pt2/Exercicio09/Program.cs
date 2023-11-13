/*
9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.
 */

public class Program
{
    public static void Main()
    {
        int quant, cont1_3 = 0, cont4_7 = 0, cont8 = 0, cont0 = 0;

        for (int i = 0; i < 30; i++)
        {
            Console.Write("Quantidade de filhos: ");
            quant = int.Parse(Console.ReadLine());

            if (quant < 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else if (quant < 8 && quant > 0)
            {
                if (quant < 4)
                {
                    cont1_3++;
                }
                else
                {
                    cont4_7++;
                }
            }
            else
            {
                if (quant == 0)
                {
                    cont0++;
                }
                else
                {
                    cont8++;
                }
            }
        }

        Console.WriteLine($"Entre 1 e 3 filhos: {cont1_3}\nEntre 4 e 7 filhos: {cont4_7}\n8 ou mais filhos: {cont8}\nNenhum filho: {cont0}");
    }
}
