using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Facade
{
    internal class SistemaBancoDeDados
    {
        public void ConfigurarBancoDeDados()
        {
            Console.WriteLine("Banco de dados configurado!");
        }

        public void IniciarBancoDeDados()
        {
            ConfigurarBancoDeDados();
            Console.WriteLine("Iniciando banco de dados!");
        }
    }
}
