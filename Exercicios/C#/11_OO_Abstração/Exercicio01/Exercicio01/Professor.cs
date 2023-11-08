using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Professor : Pessoa
    {
        public string disciplina { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nDisciplina: {disciplina}");
        }
    }
}
