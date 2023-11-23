using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Despesa
    {
        private string _descricao;
        private double _valor;

        public Despesa(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get => _descricao; set => _descricao = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
