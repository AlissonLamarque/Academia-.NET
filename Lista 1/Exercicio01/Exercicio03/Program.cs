//3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

namespace Programa
{
    public class exercicio01
    {
        public static void Main(String[] args)
        {
            int a, b, temp;
            
            a = 1;
            b = 2;

            temp = b;

            b = a;
            a = temp;
        }
    }
}
