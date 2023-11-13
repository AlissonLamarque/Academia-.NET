using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class RegistroDeCompras
    {
        static List<RegistroDeCompras> ListaCompras = new List<RegistroDeCompras>();

        public string data;
        public string produto;
        public double valor;

        public RegistroDeCompras(string data, string produto, double valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
        }

        public void AdicionarCompras()
        {
            ListaCompras.Add(this);
        }

        public void ListarCompras()
        {
            Console.WriteLine($"--- Registro de Compras ---");
            foreach (RegistroDeCompras registroCompra in ListaCompras)
            {
                Console.WriteLine($"{registroCompra.data} -> {registroCompra.produto} R${registroCompra.valor:F2}");
            }
            Console.WriteLine("----------------------------");
        }
    }
}
