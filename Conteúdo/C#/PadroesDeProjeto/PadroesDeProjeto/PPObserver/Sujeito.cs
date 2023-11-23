using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPObserver
{
    internal class Sujeito
    {
        private List<IObservador> observadores = new List<IObservador>();

        public void RegistrarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void RemoverObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores(string mensagem)
        {
            foreach (var o in observadores)
            {
                o.Atualizar(mensagem);
            }
        }
    }
}
