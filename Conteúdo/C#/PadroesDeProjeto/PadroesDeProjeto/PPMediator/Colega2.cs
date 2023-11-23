using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPMediator
{
    internal class Colega2 : Colega
    {
        public Colega2(Mediator mediator) : base(mediator) //Chamando construtor da classe base para fazer a atribuição
        {
        }

        public void Enviar(string mensagem)
        {
            _mediator.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Colega 2 recebeu a mensagem: " + mensagem);
        }
    }
}
