using Semana08.Main;
using Semana08_Classes.Modelo;

namespace Semana08.Manutencao
{
    /// <summary>
    /// Classe responsável pela manutenção de itens de produto, incluindo cadastro e listagem.
    /// </summary>
    internal class ManutencaoItemProduto
    {
        // Recuperando as listas
        /// <summary>
        /// Lista de itens de pedido.
        /// </summary>
        private List<ItemDePedido> itemDePedidos;
        /// <summary>
        /// Lista de produtos cadastrados.
        /// </summary>
        private List<Produto> produtosCadastrados;

        // Adicionando Menu como dependência para ter apenas uma lista
        /// <summary>
        /// Menu principal, usado para exibir a interface do usuário.
        /// </summary>
        private Menu menu;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ManutencaoItemProduto"/> com o menu, lista de itens de pedido e lista de produtos cadastrados especificados.
        /// </summary>
        /// <param name="menu">O menu principal.</param>
        /// <param name="itemDePedidos">A lista de itens de pedido.</param>
        /// <param name="produtosCadastrados">A lista de produtos cadastrados.</param>
        public ManutencaoItemProduto(Menu menu, List<ItemDePedido> itemDePedidos, List<Produto> produtosCadastrados)
        {
            this.menu = menu;
            this.itemDePedidos = itemDePedidos ?? new List<ItemDePedido>();
            this.produtosCadastrados = produtosCadastrados ?? new List<Produto>();
        }

        /// <summary>
        /// Cadastra um novo item de produto, solicitando o nome, a quantidade e o preço.
        /// </summary>
        public void Cadastra()
        {
            Console.Clear();
            menu.ExibirLogo();
            Console.WriteLine("\nDigite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade: ");
            string quantidadeProdutoStr = Console.ReadLine();
            int quantidadeProduto = int.Parse(quantidadeProdutoStr);
            Console.WriteLine("Digite o preço: ");
            string precoProdutoStr = Console.ReadLine();
            decimal precoProduto = decimal.Parse(precoProdutoStr);

            ItemDePedido produto = new ItemDePedido(nomeProduto, quantidadeProduto, precoProduto);
            itemDePedidos.Add(produto);
            Console.WriteLine($"O produto {nomeProduto} foi incluído com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

        /// <summary>
        /// Lista todos os itens de produto cadastrados, exibindo o nome, quantidade, preço unitário e subtotal.
        /// </summary>
        public void Lista()
        {
            Console.Clear();
            menu.ExibirLogo();
            Console.WriteLine("\nProdutos cadastrados:\n");
            itemDePedidos.ForEach(p => Console.WriteLine($"{p.Nome} - {p.Quantidade} - {p.PrecoUnitario:C} - {p.Subtotal:C}"));
            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
            Console.Clear();
            menu.ExibirLogo();
            menu.ExibirMenu();
        }

    }
}



