using System;

namespace ConjugeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Lucas Santi";
            conta.numeroAgencia = 321;
            conta.numeroConta = 70040;
            conta.saldo = 1000.0;

            Console.ReadLine();
        }
    }
}
