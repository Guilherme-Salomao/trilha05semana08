using System;
using System.Collections.Generic;
using Semana08.Classes;
using Semana08.Manutencao;


namespace Semana08.Modelo
{
    internal class Menu
    {
        //CRIANDO AS LISTAS
        private List<Produto> produtosCadastrados;
        private List<ItemDePedido> itemDePedidos;
        private ManutencaoItemProduto manutencaoItemProduto;
        private List<Cliente> clientes;
        private ManutencaoCliente manutencaoCliente;
        private ManutencaoPedido manutencaoPedido;

        //CONSTRUTOR PARA GERENCIAR A LISTA
        public Menu()
        {
            produtosCadastrados = new List<Produto>();
            itemDePedidos = new List<ItemDePedido>();
            clientes = new List<Cliente>();

            // Passando uma referência de Menu
            manutencaoItemProduto = new ManutencaoItemProduto(this, itemDePedidos, produtosCadastrados);
            manutencaoCliente = new ManutencaoCliente(this, clientes);
            manutencaoPedido = new ManutencaoPedido(this, itemDePedidos, clientes);
        }

        public void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗███████╗███╗░░░███╗░█████╗░███╗░░██╗░█████╗░  ░█████╗░░█████╗░
██╔════╝██╔════╝████╗░████║██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██╔══██╗
╚█████╗░█████╗░░██╔████╔██║███████║██╔██╗██║███████║  ██║░░██║╚█████╔╝
░╚═══██╗██╔══╝░░██║╚██╔╝██║██╔══██║██║╚████║██╔══██║  ██║░░██║██╔══██╗
██████╔╝███████╗██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║  ╚█████╔╝╚█████╔╝
╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░╚════╝░░╚════╝░");
        }

        Boolean menu = true;
        public void ExibirMenu()
        {
            while (menu)
            {
                Console.Clear();
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar um Cliente");
                Console.WriteLine("Digite 2 para listar os Clientes");
                Console.WriteLine("Digite 3 para registrar um Produto");
                Console.WriteLine("Digite 4 para listar os Produtos");
                Console.WriteLine("Digite 5 para registrar um Pedido");
                Console.WriteLine("Digite 6 para listar os Pedidos");
                Console.WriteLine("Digite 0 para sair");
                Console.Write("\nDigite a sua opção: ");

                string opcaoEscolhidaStr = Console.ReadLine().Trim(); // Remove espaços em branco extras

                // Verifica se a entrada é válida
                if (!int.TryParse(opcaoEscolhidaStr, out int opcaoEscolhida))
                {
                    Console.WriteLine("Opção inválida. Digite apenas números referentes ao menu !");
                    Console.ReadKey();
                }
                else
                {
                    switch (opcaoEscolhida)
                    {
                        case 0:
                            Console.WriteLine("Tchau tchau :)");
                            menu = false;
                            break;
                        case 1:
                            manutencaoCliente.Cadastra();
                            break;
                        case 2:
                            manutencaoCliente.Listar();
                            break;
                        case 3:
                            manutencaoItemProduto.Cadastra();
                            break;
                        case 4:
                            manutencaoItemProduto.Lista();
                            break;
                        case 5:
                            manutencaoPedido.CriarPedido(itemDePedidos, clientes);
                            break;
                        case 6:
                            manutencaoPedido.ListarPedidos();
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Escolha o número referente o que deseja realizar.");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }

    }

}



