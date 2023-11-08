/* 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23. */

public class Exercicio11
{
    public static void Main()
    {
        Console.WriteLine("Hora: ");
        int hora = int.Parse(Console.ReadLine());
        Console.WriteLine("Minuto: ");
        int minuto = int.Parse(Console.ReadLine());

        if (hora > 23 || hora < 0)
        {
            Console.WriteLine("Hora digitada não é válida");
        }
        else
        {
            if (minuto > 59 || minuto < 0)
            {
                Console.WriteLine("Hora digitada não é válida");
            }
            else
            {
                Console.WriteLine("Hora digitada é válida");
            }
        }
    }
}
