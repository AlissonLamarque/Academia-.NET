using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms1
{
    internal class Util
    {
        /// <summary>
        /// Método estático que recebe um nome completo e cria um email da UFN
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Email no domínio UFN</returns>
        public static string gerarEmail(string nome)
        {
            string[] vetor = nome.Split();
            return  (vetor[0] + "." + vetor[vetor.Length - 1] + "@ufn.edu.br").ToLower();   
        }
    }
}
