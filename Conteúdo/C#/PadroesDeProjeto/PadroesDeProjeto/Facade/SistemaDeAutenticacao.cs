using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Facade
{
    internal class SistemaDeAutenticacao
    {
        private string _user;
        private string _password;

        public SistemaDeAutenticacao(string user, string password)
        {
            _user = user;
            _password = password;
        }

        public bool VerificaDados()
        {
            return (_user.Equals("root") && _password.Equals("1234"));
        }

        public void IniciarSistema()
        {
            if (VerificaDados())
            {
                Console.WriteLine("Sistema iniciado!");
            }
            else
            {
                Console.WriteLine("Verifique usuário e senha!");
            }
        }
    }
}
