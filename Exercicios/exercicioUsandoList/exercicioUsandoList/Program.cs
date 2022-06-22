using System.Collections.Generic;
using System;
using System.Globalization;

namespace exercicioUsandoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> dadosFuncionario = new List<Funcionario>();

            Console.Write("Quantos funcionários serão inseridos? ");
            int quantFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantFuncionarios; i++)
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                dadosFuncionario.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Digite o ID do funcionário que terá o salário aumentado: ");
            int idFuncionarioBeneficiado = int.Parse(Console.ReadLine());

            Funcionario funcionario = dadosFuncionario.Find(x => x.ID == idFuncionarioBeneficiado);
            if (funcionario != null)
            {
                Console.Write("Digite a porcentagem a aumentar: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Digite uma ID válida");

            }

            Console.WriteLine("Funcionários: ");

            foreach (Funcionario obj in dadosFuncionario)
            {
                Console.WriteLine(obj);
            }



        }
    }
}