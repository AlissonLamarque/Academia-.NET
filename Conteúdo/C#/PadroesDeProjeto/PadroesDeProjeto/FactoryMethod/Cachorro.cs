using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.FactoryMethod
{
    internal class Cachorro : IAnimal
    {
        public string Raca { get; set; }


        public void FazerSom()
        {
            Console.WriteLine("Au au!");
        }
    }
}
