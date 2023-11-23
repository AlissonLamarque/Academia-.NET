using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO0611
{
    internal abstract class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public abstract void EmitirSom();

        public void Movimentar()
        {
            Console.WriteLine("Ele se movimentou");
        }
    }
}
