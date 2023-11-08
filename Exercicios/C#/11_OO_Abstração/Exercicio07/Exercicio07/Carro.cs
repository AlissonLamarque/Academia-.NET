using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Carro : Veiculo
    {
        static List<Carro> listaCarro = new List<Carro>();

        public int qtdPortas { get; set; }
    }
}
