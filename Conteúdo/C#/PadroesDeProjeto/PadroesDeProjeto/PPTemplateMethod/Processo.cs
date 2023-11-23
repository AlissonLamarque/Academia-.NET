using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPTemplateMethod
{
    public abstract class Processo
    {
        public abstract void Iniciar();

        public abstract void Finalizar();

        public virtual void Executar()
        {
            Console.WriteLine("Iniciando - Estou aqui, na implementação da classe abstrata do método executar");
            Iniciar();
            Console.WriteLine("Finalizando - Estou aqui, na implementação da classe abstrata do método executar");
            Finalizar();
        }

        public void RegistrarProcesso()
        {
            Console.WriteLine("Registrando processo! Na classe abstrata!");
        }
    }
}
