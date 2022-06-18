using System;
using System.Globalization;

namespace exercicio_calcularMediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Olá! Digite suas três notas: ");
            Console.Write("Nota 1: ");
            aluno1.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            aluno1.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            aluno1.nota3 = double.Parse(Console.ReadLine());

            if (aluno1.nota1 <= 30 && aluno1.nota2 <= 35 && aluno1.nota3 <= 35)
            {
                aluno1.calcularNota();
                aluno1.verificaAprovacao();
            }
            else
            {
                Console.WriteLine("Digite notas válidas, o primeiro trimestre vale 30 e o segundo e terceiro valem 35");
            }


        }
    }
}