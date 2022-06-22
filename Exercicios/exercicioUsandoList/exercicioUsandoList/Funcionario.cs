using System;
using System.Globalization;

namespace exercicioUsandoList
{
    internal class Funcionario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Percentage { get; set; }

        public Funcionario(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

        public double AumentarSalario(double Percentage)
        {
            return Salary = Salary * (1 + (Percentage/ 100));
        }

        public override string ToString()
        {
            return $"{ID} - {Name} - {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
