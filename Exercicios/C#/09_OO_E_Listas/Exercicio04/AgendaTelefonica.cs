using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class AgendaTelefonica
    {
        static List<AgendaTelefonica> _AgendaTelefonica = new List<AgendaTelefonica>();

        public string nome;
        public string email;
        public string telefone;

        public AgendaTelefonica(string nome, string email, string tel)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = tel;
        }

        void AdicionarContato()
        {
            _AgendaTelefonica.Add(this);
        }

        void RemoverContato()
        {
            _AgendaTelefonica.Remove(this);
        }

        void ListarContato()
        {
            foreach (AgendaTelefonica telefone in _AgendaTelefonica)
            {
                Console.WriteLine($"Nome: {telefone.nome} - Tel: {telefone.telefone} - Email: {telefone.email}");
            }
        }
    }
}
