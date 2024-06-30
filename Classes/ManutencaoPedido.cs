using System;
using System.Collections.Generic;
using Semana08.Modelos; // Importe outras classes necessárias

namespace Semana08.Classes
{
    internal class ManutencaoPedido
    {
        private List<Pedido> pedidos;
        private Menu menu; // Referência ao menu para navegação

        public ManutencaoPedido(Menu menu, List<ItemDePedido> itensDisponiveis, List<Cliente> clientes)
        {
            this.menu = menu;
            this.pedidos = new List<Pedido>();
        }

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
