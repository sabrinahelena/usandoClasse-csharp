

namespace exercicio_usandoVetores
{
    internal class Menu : Apresentacao
    {
        public void MenuApresentacao()
        {
            int i = 0;
            Atualizacao atualizacao = new Atualizacao();
            Localizacao buscar = new Localizacao();
            while (i == 0)
            {
                Console.WriteLine(Environment.NewLine + $"Olá! Seja bem vindo! Digite a ação que deseja realizar: " + Environment.NewLine +
                    $"1 - Apresentar todos itens separados por ;" + Environment.NewLine +
                    $"2 - Apresentar quantidade de itens da lista" + Environment.NewLine +
                    $"3 - Apresentar todos itens com seus respectivos índices" + Environment.NewLine +
                    $"4 - Adicionar um novo item pelo nome " + Environment.NewLine +
                    $"5 - Atualizar um item a partir do seu índice" + Environment.NewLine +
                    $"6 - Buscar item pelo índice " + Environment.NewLine +
                    $"7 - Sair do menu" + Environment.NewLine);

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ApresentarListaPontoeVirgula();
                        break;
                    case 2:
                        ApresentarQuantidadeItens();
                        break;
                    case 3:
                        ApresentarItensComPosicaoNaLista();
                        break;
                    case 4:
                        atualizacao.AdicionarNovoItemPeloNome();
                        break;
                    case 5:
                        atualizacao.AtualizarUmItemPeloIndice();
                        break;
                    case 6:
                        buscar.BuscarNomeItemPeloIndice();
                        break;
                    case 7:
                        i = 1;
                        break;


                }
            }
        }

    }
}
