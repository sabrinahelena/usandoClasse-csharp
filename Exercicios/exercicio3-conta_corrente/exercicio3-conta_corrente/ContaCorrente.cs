using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_conta_corrente
{
    internal class ContaCorrente
    {
        public string Nome;
        public int NumeroDaConta;
        public double SaldoDaConta;
        public string NomeAlterado;
        public double Deposito;
        public double Saque;


        public void alterarNome()
        {
            Console.WriteLine("Digite o novo nome: ");
            NomeAlterado = Console.ReadLine();
            Nome = NomeAlterado;
            Console.WriteLine($"Ok, nome alterado para: {Nome}");
        }
        public void depositar()
        {
            Console.WriteLine("Quanto você deseja depositar? ");
            Deposito = Convert.ToDouble(Console.ReadLine());
            SaldoDaConta += Deposito;
            Console.WriteLine($"Valor atual: {SaldoDaConta}");
        }

        public void sacar()
        {
            Console.WriteLine("Quanto você deseja sacar? ");
            Saque  = Convert.ToDouble(Console.ReadLine());
            SaldoDaConta -= Saque;
            Console.WriteLine($"Valor atual: {SaldoDaConta}");
        }

        public void status()
        {
            Console.WriteLine($"Olá, {Nome}, bem vindo! Você possui {SaldoDaConta} atualmente em seu banco. ");
        }

    }
}
