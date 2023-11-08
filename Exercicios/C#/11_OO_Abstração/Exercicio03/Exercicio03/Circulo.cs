using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Circulo : IFormaGeometrica
    {
        public double raio { get; set; }

        public void CalcularArea()
        {
            Console.WriteLine($"Área do Circulo: {3.14 * (raio * raio):F2}m²");
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine($"Perimetro do Circulo: {2 * 3.14 * raio:F2}m");
        }
    }
}
