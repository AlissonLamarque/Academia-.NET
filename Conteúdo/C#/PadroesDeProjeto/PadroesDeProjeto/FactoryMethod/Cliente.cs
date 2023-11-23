using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.FactoryMethod
{
    internal class Cliente
    {
        private IAnimalFactory animalFactory;

        public Cliente(IAnimalFactory factory)
        {
            animalFactory = factory;
        }

        public void InteragirComAnimal()
        {
            IAnimal animal = animalFactory.CriarAnimal();
            Console.WriteLine("Animal faz o som:");
            animal.FazerSom();
        }
    }
}
