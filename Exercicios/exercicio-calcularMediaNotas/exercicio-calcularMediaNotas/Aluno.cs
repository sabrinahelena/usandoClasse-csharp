

namespace exercicio_calcularMediaNotas
{
    internal class Aluno
    {
        public string nomeAluno;
        public double nota1;
        public double nota2;
        public double nota3;
        public double resultadoMedia;

        public void calcularNota()
        {
            this.resultadoMedia = (nota1 + nota2 + nota3);
            Console.WriteLine($"Resultado final: {this.resultadoMedia}");
        }

        public void verificaAprovacao()
        {
            if (this.resultadoMedia < 60)
            {
                Console.WriteLine($"Reprovado, faltaram {60-this.resultadoMedia} pontos para passar");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
           
        }

    }
}
