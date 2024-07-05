using Semana08.Main;

namespace Semana08.Manutencao
{
    internal class ManutencaoItemProduto
    {
        // Recuperando as listas
        private List<ItemDePedido> itemDePedidos;
        private List<Produto> produtosCadastrados;
        // Adicionando Menu como dependência para ter apenas uma lista
        private Menu menu;

        public ManutencaoItemProduto(Menu menu, List<ItemDePedido> itemDePedidos, List<Produto> produtosCadastrados)
        {
            this.menu = menu;
            this.itemDePedidos = itemDePedidos ?? new List<ItemDePedido>();
            this.produtosCadastrados = produtosCadastrados ?? new List<Produto>();
        }

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



