namespace exercicio3_conta_corrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            int i = 0;

            Console.WriteLine("Olá, qual é o seu nome?: ");
            c1.Nome = Console.ReadLine();
            while (i < 1)
            {
                Console.WriteLine($"O que você deseja fazer?>\r\n " +
                $"1 - Verificar saldo\r\n " +
                $"2 - Sacar\r\n " +
                $"3 - Depositar\r\n " +
                $"4 - Alterar nome. ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        c1.status();
                        break;
                    case 2:
                        c1.sacar();
                        break;
                    case 3:
                        c1.depositar();
                        break;
                    case 4:
                        c1.alterarNome();
                        break;
                    default:
                        Console.WriteLine("Digite um valor válido, entre 1 e 4");
                        break;
                }
                Console.WriteLine("Deseja sair do menu? Digite 1 para sim e 0 para não");
                i = Convert.ToInt32(Console.ReadLine());
            }

        }


    }
}
