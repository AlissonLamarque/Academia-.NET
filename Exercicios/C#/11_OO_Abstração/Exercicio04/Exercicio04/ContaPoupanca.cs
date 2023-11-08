using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Depósito feito com sucesso");
        }

        public override void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para transação");
            }
            else
            {
                saldo -= valor + 0.1;
                Console.WriteLine("Saque feito com sucesso");
            }
        }
    }
}
