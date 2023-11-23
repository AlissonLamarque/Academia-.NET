using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPEstrategy
{
    internal class ContextoOrdenacao
    {
        private IAlgoritmoOrdenacao algoritmo;

        public ContextoOrdenacao(IAlgoritmoOrdenacao algoritmo)
        {
            this.Algoritmo = algoritmo;
        }

        public IAlgoritmoOrdenacao Algoritmo { get => algoritmo; set => algoritmo = value; }

        public void ExecutarOrdenacao(List<int> lista)
        {
            algoritmo.Ordenar(lista);
        }
    }
}
