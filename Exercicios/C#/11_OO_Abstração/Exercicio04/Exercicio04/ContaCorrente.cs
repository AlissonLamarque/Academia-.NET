using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class ContaCorrente : ContaBancaria
    {
        public int cont = 0;

        public override void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito feito com sucesso\nSaldo: R${saldo}");
        }

        public override void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para transação");
            }
            else
            {
                if (cont == 0)
                {
                    saldo -= valor;
                    cont++;
                    Console.WriteLine("Saque feito com sucesso");
                }
                else
                {
                    saldo -= valor - 0.05;
                    Console.WriteLine("Saque feito com sucesso");
                }
            }
        }
    }
}
