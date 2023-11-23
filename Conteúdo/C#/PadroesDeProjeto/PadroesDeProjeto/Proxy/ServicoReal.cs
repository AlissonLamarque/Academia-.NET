using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Proxy
{
    internal class ServicoReal : IServico
    {
        public void Solicitar()
        {
            Console.WriteLine("Serviço real: Serviço solicitado pelo cliente!");
        }
    }
}
