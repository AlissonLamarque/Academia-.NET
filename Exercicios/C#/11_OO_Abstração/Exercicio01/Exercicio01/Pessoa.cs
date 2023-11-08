using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal abstract class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public abstract void Apresentar();
    }
}
