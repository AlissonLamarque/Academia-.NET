using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Musica
    {
        public string nome {  get; set; }
        public string autor {  get; set; }
        public string gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }
    }
}
