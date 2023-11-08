using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Carro : Veiculo
    {
        public int qtdPortas { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirindo o(a) {marca} {modelo} com {qtdPortas} portas");
        }
    }
}
