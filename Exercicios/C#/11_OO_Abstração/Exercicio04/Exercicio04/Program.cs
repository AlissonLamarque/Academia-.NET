// 4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar".
// Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de
// acordo com as regras de cada tipo de conta.

using Exercicio04;

public class Program
{
    public static void Main()
    {
        ContaCorrente contaCorrente = new ContaCorrente();

        contaCorrente.Depositar(105.50);
        contaCorrente.Sacar(50);
        contaCorrente.Sacar(60);

        contaCorrente.Sacar(50);
        contaCorrente.Depositar(105.50);
        contaCorrente.Sacar(60);
    }
}