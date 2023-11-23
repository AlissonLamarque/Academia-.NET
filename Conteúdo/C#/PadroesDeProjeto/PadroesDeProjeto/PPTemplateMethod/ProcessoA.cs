using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPTemplateMethod
{
    internal class ProcessoA : Processo
    {
        public override void Iniciar()
        {
            Console.WriteLine("Iniciando o processo A");
        }

        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o processo A");
        }
    }
}
