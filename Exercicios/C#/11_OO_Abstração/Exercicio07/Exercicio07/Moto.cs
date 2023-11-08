using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Moto : Veiculo
    {
        static List<Moto> listaMoto = new List<Moto>();

        public double cilindrada { get; set; }
    }
}
