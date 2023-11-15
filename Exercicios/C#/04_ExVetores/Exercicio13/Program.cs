// 13. Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes
// aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando
// for digitado -1 ou quando atingir o máximo de posições do vetor.

public class Exercicio13
{
    public static void Main()
    {
        int[] vetor = new int[100];

        int valor, cont2 = 0, cont4 = 0, cont8 = 0;

        for (int i = 0; i < 100; i++)
        {
            Console.Write("Valor: ");
            valor = int.Parse(Console.ReadLine());

            if (valor == -1)
                break;
            else
            {
                vetor[i] = valor;
                if (valor == 2)
                    cont2++;
                else if (valor == 4) 
                    cont4++;
                else if (valor == 8) 
                    cont8++;
            }
        }
        Console.WriteLine($"2: {cont2} vezes\n4: {cont4} vezes\n8: {cont8} vezes");
    }
}

