using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
            Email = Util.gerarEmail(nome);
        }

        public override string ToString()
        {
            return Nome + "\t\t" + Email;
        }
    }
}
