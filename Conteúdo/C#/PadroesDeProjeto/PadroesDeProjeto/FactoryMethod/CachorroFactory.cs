using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.FactoryMethod
{
    internal class CachorroFactory : IAnimalFactory
    {
        public IAnimal CriarAnimal()
        {
            return new Cachorro();
        }
    }
}
