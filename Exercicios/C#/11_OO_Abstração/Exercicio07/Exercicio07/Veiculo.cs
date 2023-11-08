using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal abstract class Veiculo
    {
        static List<Veiculo> listaVeiculo = new List<Veiculo>();

        public string marca { get; set; }
        public int ano { get; set; }
    }
}
