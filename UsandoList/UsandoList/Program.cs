using System.Collections.Generic; //É necessário para usar List


namespace UsandoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string> { "São Paulo", "Belo Horizonte", "Rio de Janeiro" }; //Declaração de lista
            //List<string> cidades = new List<string>(); Assim declara lista vazia.

            cidades.Add("Florianopolis"); // adiciona 
            cidades.Insert(2, "Brasilia"); //Adiciona Brasilia no índice 2, pulando o que estiver no 2 para a próxima posição.
            int contador = cidades.Count(); //conta quantos valores tem na lista
            Console.WriteLine($"Essa lista possui {contador} valores");
            cidades.Remove("Florianopolis"); //remove florianopolis
            cidades.RemoveAt(2);//remove oque estiver na posição 2 

            foreach (string cid in cidades) //para cada objeto no vetor cidades,
            {
                Console.WriteLine(cid); //imprimir os objetos
            }
        }
    }
}