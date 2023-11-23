using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.FactoryMethod
{
    internal class Gato : IAnimal
    {


        public void FazerSom()
        {
            Console.WriteLine("Miau miau!");
        }
    }
}
