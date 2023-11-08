using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Eletronico : Produto
    {
        public override void CalcularDesconto()
        {
            double desconto;
            desconto = preco * 0.125;
            Console.WriteLine($"Desconto: R${desconto:F2}");
        }
    }
}
