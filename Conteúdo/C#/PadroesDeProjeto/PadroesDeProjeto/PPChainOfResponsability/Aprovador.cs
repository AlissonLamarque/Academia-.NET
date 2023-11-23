using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPChainOfResponsability
{
    abstract class Aprovador : IHandler
    {
        protected IHandler ProximoHandler;
        //ainda estou adiando a implementação deste método pois quem vai implementar serão os manipuladores
        public abstract void AprovarDespesa(Despesa despesa);

        public void DefinirProximoHandler(IHandler proxHandler)
        {
            ProximoHandler = proxHandler;
        }
    }
}
