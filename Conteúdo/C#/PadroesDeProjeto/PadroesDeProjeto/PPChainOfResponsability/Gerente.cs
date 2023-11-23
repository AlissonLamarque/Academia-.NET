using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Gerente : Aprovador
    {
        public override void AprovarDespesa(Despesa despesa)
        {
            if (despesa.Valor <= 500)
            {
                Console.WriteLine("Despesa aprovada pelo gerente!");
            }
            else if (ProximoHandler != null)
            {
                ProximoHandler.AprovarDespesa(despesa);
            }
            else
            {
                Console.WriteLine("O gerente não pode aprovar esta conta!");
            }
        }
    }
}
