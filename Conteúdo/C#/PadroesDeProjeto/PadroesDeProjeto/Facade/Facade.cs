using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Facade
{
    internal class Facade
    {
        private SistemaBancoDeDados _sistemaBD;
        private SistemaServidorWeb _servidorWeb;
        private SistemaDeAutenticacao _sistemaAutenticacao;

        public Facade(string user, string password)
        {
            _sistemaBD = new SistemaBancoDeDados();
            _servidorWeb = new SistemaServidorWeb();
            _sistemaAutenticacao = new SistemaDeAutenticacao(user, password);
        }

        public void InicializarSistema()
        {
            Console.WriteLine("Iniciando todos os componentes: ");
            _sistemaBD.IniciarBancoDeDados();
            _servidorWeb.IniciarServidor();
            _sistemaAutenticacao.IniciarSistema();
        }
    }
}
