// 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés)
// e uma unidade de medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor
// de entrada e converter esse valor para a unidade de saída selecionada.

public class Exercicio21
{
    public static void Main()
    {
        double valor;
        int op, op2;

        do
        {
            Console.WriteLine("Unidade de entrada");
            Console.Write("1 - Metros\n2 - Centímetros\n3 - Polegadas\n4 - Pés\n Sua opção: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("Unidade de saída");
            Console.Write("1 - Metros\n2 - Centímetros\n3 - Polegadas\n4 - Pés\n Sua opção: ");
            op2 = int.Parse(Console.ReadLine());

            Console.Write("Valor de entrada: ");
            valor = double.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    switch (op2)
                    {
                        case 1: Console.WriteLine(valor); break;
                        case 2: Console.WriteLine(valor * 100); break;
                        case 3: Console.WriteLine(valor * 39.3701); break;
                        case 4: Console.WriteLine(valor * 3.28084); break;
                    }
                    break;
                case 2:
                    switch (op2)
                    {
                        case 1: Console.WriteLine(valor / 100); break;
                        case 2: Console.WriteLine(valor); break;
                        case 3: Console.WriteLine(valor * 39.3701); break;
                        case 4: Console.WriteLine(valor * 3.28084); break;
                    }
                    break;
                case 3:
                    switch (op2)
                    {
                        case 1: Console.WriteLine(valor * 0.0254); break;
                        case 2: Console.WriteLine(valor * 2.54); break;
                        case 3: Console.WriteLine(valor); break;
                        case 4: Console.WriteLine(valor * 0.0833333); break;
                    }
                    break;
                case 4:
                    switch (op2)
                    {
                        case 1: Console.WriteLine(valor * 0.3048); break;
                        case 2: Console.WriteLine(valor * 30.48); break;
                        case 3: Console.WriteLine(valor * 12); break;
                        case 4: Console.WriteLine(valor); break;
                    }
                    break;
                case 5:
                    break;
            }
        } while (op != 5);
    }
}