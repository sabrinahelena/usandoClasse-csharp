namespace exercicio2_saldoMedio
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario(); ;//criou 2 funcionarios na classe

            Console.WriteLine("Digite o primeiro nome>");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário>");
            f1.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Digite o segundo nome>");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário>");
            f2.Salario = Convert.ToDouble(Console.ReadLine());


            //função de cálculo da média do salário
            double calcularMediaSalario(double salario1, double salario2)
            {
                return (salario1 + salario2) / 2;
            }

            Console.WriteLine("A media dos salários é: " + calcularMediaSalario(f1.Salario, f2.Salario));

        }
    }
}