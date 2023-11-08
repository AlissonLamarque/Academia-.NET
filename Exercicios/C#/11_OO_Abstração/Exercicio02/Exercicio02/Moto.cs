using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Moto : Veiculo
    {
        public int cilindrada { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Pilotando o(a) {marca} {modelo} com {cilindrada} cilindradas");
        }
    }
}
