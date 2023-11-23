using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Proprietario : Aprovador
    {
        public override void AprovarDespesa(Despesa despesa)
        {
            if (despesa.Valor <= 50000)
            {
                Console.WriteLine("Despesa aprovada pelo Dono da empresa!");
            }
            else
            {
                Console.WriteLine("Ninguém pagará por esta conta!");

            }
        }
    }
}
