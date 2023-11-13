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

        public void armazenarContato(string nome, string email, string tel)
        {
            AgendaTelefonica contato = new AgendaTelefonica(nome, email, tel);
            _AgendaTelefonica.Add(contato);
        }

        public void removerContato(string nome, string tel)
        {
            bool cttEncontrado = false;
            foreach (AgendaTelefonica telefone in _AgendaTelefonica)
            {
                if (telefone.nome == nome && telefone.telefone == tel)
                {
                    _AgendaTelefonica.Remove(telefone);
                    cttEncontrado |= true;
                    break;
                }
            }
            if (!cttEncontrado)
            {
                Console.WriteLine("Contato não encontrado");
            }
        }

        public void buscarContato(string nome)
        {
            bool cttEncontrado = false;
            foreach (AgendaTelefonica telefone in _AgendaTelefonica)
            {
                if (telefone.nome == nome)
                {
                    Console.WriteLine($"Nome: {telefone.nome} - Tel: {telefone.telefone} - Email: {telefone.email}");
                    cttEncontrado |= true;
                }
            }
            if (!cttEncontrado)
            {
                Console.WriteLine("Contato não encontrado");
            }
        }

        public void listarContato()
        {
            foreach (AgendaTelefonica telefone in _AgendaTelefonica)
            {
                Console.WriteLine($"Nome: {telefone.nome} - Tel: {telefone.telefone} - Email: {telefone.email}");
            }
        }
    }
}
