using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPMediator
{
    internal class MediatorConcreto : Mediator
    {
        public Colega1 colega1;
        public Colega2 colega2;

        public override void Enviar(string mensagem, Colega colega)
        {
            if (colega == colega1)
            {
                colega1.Notificar(mensagem);
            }
            else if (colega == colega2)
            {
                colega2.Notificar(mensagem);
            }
        }
    }
}
