namespace usandoMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do seu vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n]; //3 linhas 3 colunas

            //Define a matriz
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' '); //le os valores que o usuário digita e separa
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]); //pega os valores separados de values e joga em matriz, sendo i a linha e j coluna
                }
            }


            //Imprime a matriz
            string linha = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine(linha);
                linha = "_________\n";
                string separador = " ";
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(separador + matriz[i, j]);
                    separador = " | ";
                }
                Console.WriteLine(); //Faz ficar em colunas
            }

        }
    }
}