using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Presidente : Aprovador
    {
        public override void AprovarDespesa(Despesa despesa)
        {
            if (despesa.Valor <= 5000)
            {
                Console.WriteLine("Despesa aprovada pelo Presidente!");
            }
            else if (ProximoHandler != null)
            {
                Console.WriteLine("O presidente não pode aprovar esta conta!");
                int op;
                Console.WriteLine("Digite 1 para enviar para o dono da empresa ou 2 para cancelar o pagamento: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1) ProximoHandler.AprovarDespesa(despesa);
                else Console.WriteLine("Conta não paga!");
            }
            else
            {
                Console.WriteLine("O presidente não pode aprovar esta conta!");

            }
        }
    }
}
