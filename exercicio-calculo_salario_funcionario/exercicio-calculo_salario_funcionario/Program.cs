using System;
using System.Globalization;

namespace exercicio_calculo_salario_funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Console.WriteLine("Digite o seu ID de funcionário: ");
            f1.numeroFuncionario = (int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor de horas que você trabalho e quanto você ganha por hora: ");
            string[] dadosSalario = (Console.ReadLine().Split(' '));

            f1.horasTrabalhadas = (double.Parse(dadosSalario[0], CultureInfo.InvariantCulture));
            f1.valorPorHoras = (double.Parse(dadosSalario[1], CultureInfo.InvariantCulture));

            Console.WriteLine($"O seu salário é de: {f1.calcularSalario(f1.horasTrabalhadas, f1.valorPorHoras).ToString("F2")}");

        }
    }
}