//Classe criada para apresentação dos membros da lista.

namespace exercicio_usandoVetores
{
    
    internal class Apresentacao : Lista
    {
        // 1.1. Apresenta todos os itens da lista separados por ponto e vírgula.

        protected  void ApresentarListaPontoeVirgula()
        {
            for (int i = 0; i < listaDeCidades.Length; i++)
            {
                Console.WriteLine($"{listaDeCidades[i]};");
            }
        }

        // 1.2. Apresentar quantidade de itens da lista.

        protected  void ApresentarQuantidadeItens()
        {
            Console.WriteLine(listaDeCidades.Length);
        }

        // 1.6. Listar todos os itens com seu índice/posição na lista.

        protected  void ApresentarItensComPosicaoNaLista()
        {
            for(int i = 0; i < listaDeCidades.Length; i++)
            {
                Console.WriteLine($"{i + 1 } - {listaDeCidades[i]} ");
            }
        }


    }
}
