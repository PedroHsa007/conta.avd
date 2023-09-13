using System;
using trabalho_avd1;

namespace ControleContas
{
    class Program
    {
        static void Main(string[] args) 
        {
            Conta conta1 = new Conta();
            conta1.Numero = 123456;
            Console.WriteLine(conta1.Numero);
        }
    }
}