namespace exercicio_calculo_salario_funcionario
{
    internal class Funcionario
    {
        public int numeroFuncionario;
        public double horasTrabalhadas;
        public double valorPorHoras;


        public double calcularSalario(double horasTrabalhadas, double valorPorHoras)
        {
            return valorPorHoras * horasTrabalhadas;
        }

       
    }
}
