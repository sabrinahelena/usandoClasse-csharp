

namespace exercicio_usandoVetores
{
    internal class Atualizacao : Apresentacao
    {
        // 1.4. Adiciona um novo item a lista pelo seu nome.

        public void AdicionarNovoItemPeloNome()
        {
            Console.WriteLine("Digite o nome da cidade a ser adicionada: ");
            string nomeCidade = Console.ReadLine();
            listaDeCidades = listaDeCidades.Append(nomeCidade).ToArray();

            ApresentarItensComPosicaoNaLista();
        }
        // 1.5. Atualiza um item a partir do seu índice na lista.

        public void AtualizarUmItemPeloIndice()
        {
            Console.WriteLine("Digite o índice em que você deseja atualizar a cidade: ");
            int indice = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da cidade que irá ficar nesse índice: ");
            string nomeCidade = Console.ReadLine();
            listaDeCidades[indice] = nomeCidade;

            ApresentarItensComPosicaoNaLista();
        }

    }
}
