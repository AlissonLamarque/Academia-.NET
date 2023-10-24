/* 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário. */

public class Exercicio12
{
    public static void Main(string[] args)
    {
        int codigo, numeroHoras, extraHoras, extra, salario;

        Console.WriteLine("Código: ");
        codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Horas trabalhadas: ");
        numeroHoras = int.Parse(Console.ReadLine());

        if (numeroHoras > 50)
        {
            extraHoras = -50 + numeroHoras;
            extra = extraHoras * 20;
            salario = (numeroHoras - extraHoras) * 10;
        }
        else
        {
            salario = numeroHoras * 10;
            extra = 0;
        }

        Console.WriteLine($"Operário {codigo}\nSalário total: R${salario}\nSalário excedente: R${extra}");
    }
}