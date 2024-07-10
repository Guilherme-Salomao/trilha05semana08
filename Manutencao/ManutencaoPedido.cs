using Semana08_Classes.Modelo;
using Semana08.Main;

namespace Semana08.Manutencao
{
    /// <summary>
    /// Classe responsável pela manutenção de pedidos, incluindo a criação e a listagem de pedidos.
    /// </summary>
    internal class ManutencaoPedido
    {
        /// <summary>
        /// Lista de pedidos.
        /// </summary>
        private List<Pedido> pedidos;

        /// <summary>
        /// Menu principal, usado para exibir a interface do usuário.
        /// </summary>
        private Menu menu; // Referência ao menu para navegação

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ManutencaoPedido"/> com o menu, lista de itens disponíveis e lista de clientes especificados.
        /// </summary>
        /// <param name="menu">O menu principal.</param>
        /// <param name="itensDisponiveis">A lista de itens disponíveis para pedido.</param>
        /// <param name="clientes">A lista de clientes.</param>
        public ManutencaoPedido(Menu menu, List<ItemDePedido> itensDisponiveis, List<Cliente> clientes)
        {
            this.menu = menu;
            this.pedidos = new List<Pedido>();
        }

        /// <summary>
        /// Cria um novo pedido solicitando a seleção de um cliente e de produtos disponíveis.
        /// </summary>
        /// <param name="itensDisponiveis">A lista de itens disponíveis para pedido.</param>
        /// <param name="clientes">A lista de clientes.</param>
        public void CriarPedido(List<ItemDePedido> itensDisponiveis, List<Cliente> clientes)
        {
            Console.Clear();
            menu.ExibirLogo();

            // Listar Clientes para cadastrar pedido
            Console.WriteLine("\nClientes Cadastrados:");
            int index = 1;
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{index++}. {cliente.Nome}");
            }

            // Listar produtos para cadastrar pedido
            Console.WriteLine("\nProdutos Disponíveis:");
            index = 1;
            foreach (var item in itensDisponiveis)
            {
                Console.WriteLine($"{index++}. {item.Nome} - {item.PrecoUnitario:C} - Quantidade em estoque: {item.Quantidade}");
            }

            Console.Write("\nDigite o número do cliente: ");
            int indiceCliente = int.Parse(Console.ReadLine()) - 1; // Ajuste de índice para lista (começa do 0)
            Cliente clienteSelecionado = clientes[indiceCliente];

            Console.Write("Digite o número do produto desejado: ");
            int indiceProduto = int.Parse(Console.ReadLine()) - 1; // Ajuste de índice para lista (começa do 0)
            ItemDePedido produtoSelecionado = itensDisponiveis[indiceProduto];

            Console.Write("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Verifica se a quantidade desejada é válida
            if (quantidade <= 0 || quantidade > produtoSelecionado.Quantidade)
            {
                Console.WriteLine("Quantidade inválida.");
                Console.WriteLine("Aperte qualquer tecla para voltar.");
                Console.ReadKey();
                return;
            }


            // Criar o pedido com os dados fornecidos
            Pedido novoPedido = new Pedido(clienteSelecionado, DateTime.Now, new List<ItemDePedido>());
            novoPedido.AdicionarItem(new ItemDePedido(produtoSelecionado.Nome, quantidade, produtoSelecionado.PrecoUnitario));

            // Adicionar o pedido à lista de pedidos
            pedidos.Add(novoPedido);

            Console.WriteLine("\nPedido criado com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadKey();
        }

        /// <summary>
        /// Lista todos os pedidos cadastrados, exibindo os detalhes de cada pedido.
        /// </summary>
        public void ListarPedidos()
        {
            Console.Clear();
            menu.ExibirLogo();
            Console.WriteLine("\nLista de Pedidos:\n");
            foreach (var pedido in pedidos)
            {
                pedido.ExibirPedido();
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("\nAperte qualquer tecla para voltar.");
            Console.ReadKey();
        }
    }
}
