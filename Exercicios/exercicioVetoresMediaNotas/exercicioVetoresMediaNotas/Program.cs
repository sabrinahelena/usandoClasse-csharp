namespace exercicioVetoresMediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Console.WriteLine("Olá! Seja bem-vindo! ");

            Console.Write("Digite o seu nome: ");
            a1.NomeAluno = Console.ReadLine();


            Aluno[] Notas = new Aluno[4];

            Console.WriteLine("Digite as notas dos 4 bimestres:");
            for (int i=0; i<Notas.Length; i++)
            {
                Console.Write($"Digite a nota do {i + 1} bimestre: ");
                int notas = int.Parse(Console.ReadLine());

                Notas[i] = new Aluno { Nota = notas };

            }

            int somaNotas = 0;

            for(int i = 0; i<Notas.Length; i++)
            {
                somaNotas += Notas[i].Nota;
            }

            string resultado;
            if (somaNotas < 60)
            {
                 resultado = ("reprovado");
            }
            else
            {
                 resultado = ("aprovado");
            }

            Console.WriteLine($"{a1.NomeAluno}, a sua nota final é : {somaNotas} e você está {resultado} ");


        }
    }
}