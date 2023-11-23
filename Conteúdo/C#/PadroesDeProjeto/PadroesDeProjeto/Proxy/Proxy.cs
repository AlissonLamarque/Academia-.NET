using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Proxy
{
    internal class Proxy : IServico
    {
        private ServicoReal _servicoReal;

        public void Solicitar()
        {
            if (_servicoReal == null)
            {
                _servicoReal = new ServicoReal();
                Console.WriteLine("Instanciando um objeto da classe ServicoReal");
            }

            Console.WriteLine("Estou aqui no proxy chamando o serviço real!");
            _servicoReal.Solicitar();
        }
    }
}
