using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaIsabela = new ContaCorrente();
            contaIsabela.titular = "Isabela";
            contaIsabela.agencia = 847;
            contaIsabela.numero = 8476270;

            Console.ReadLine();
        }
    }
}
