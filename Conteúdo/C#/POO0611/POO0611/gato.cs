using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO0611
{
    internal class Gato : Animal
    {

        public int Vidas { get; set; }

        public Gato(string nome, int vidas) : base(nome)
        {
            Vidas = vidas;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }

        public void Ronronar()
        {
            Console.WriteLine("Rrrrrrrrr...");
        }
    }
}
