using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto
{
    internal class ConfiguracaoSingleton
    {
        private static ConfiguracaoSingleton instancia;

        private string _url { get; set; }
        private int _versao { get; set; }
        private int _porta { get; set; }

        public string Url { get { return _url; } }
        public int Versao { get { return _versao; } }
        public int Porta { get { return _porta; } }

        public ConfiguracaoSingleton()
        {
            _url = "localhost";
            _versao = 1;
            _porta = 8080;
        }

        public static ConfiguracaoSingleton getInstance()
        {
            if (instancia == null)
            {
                instancia = new ConfiguracaoSingleton();
            }

            return instancia;
        }

        public void ExibirDados()
        {
            Console.WriteLine("URL: " + _url);
            Console.WriteLine("Porta: " + _porta);
            Console.WriteLine("Versão: " + _versao);
        }
    }
}
