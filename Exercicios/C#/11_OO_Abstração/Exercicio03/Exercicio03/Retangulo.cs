using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Retangulo : IFormaGeometrica
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }

        public void CalcularArea()
        {
            Console.WriteLine($"Área do retângulo: {lado1 * lado2:F2}m²");
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine($"Perimetro do retângulo: {(lado1 * 2) + (lado2 * 2):F2}m");
        }
    }
}
