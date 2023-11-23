using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPTemplateMethod
{
    internal class ProcessoC : Processo
    {
        public override void Finalizar()
        {
            Console.WriteLine("Iniciando o processo C");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Finalizando o processo C");
        }

        public override void Executar()
        {
            Console.WriteLine("Estou no método reimplementado do ProcessoC");
            Iniciar();
            Finalizar();
        }
    }
}
