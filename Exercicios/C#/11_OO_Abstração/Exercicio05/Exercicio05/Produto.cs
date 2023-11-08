using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal abstract class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public abstract void CalcularDesconto();
    }
}
