

namespace exercicio_usandoVetores
{
    internal class Localizacao : Apresentacao
    {
        // 1.3. Buscar o nome do item de acordo com seu índice.

        public void BuscarNomeItemPeloIndice()
        {
            Console.WriteLine("Digite o índice que você deseja localizar o item: ");
            int indice = int.Parse(Console.ReadLine());
            Console.WriteLine($"O item localizado no {indice} é o {listaDeCidades[indice]}");
        }


    }
}
