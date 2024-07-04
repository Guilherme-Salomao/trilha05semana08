using Semana08.Classes;
using Semana08.Modelo;
using System;
using System.Collections.Generic;

namespace Semana08.Manutencao
{
    internal class ManutencaoCliente
    {
        //RECUPERANDO A LISTA
        private List<Cliente> clientes;
        // Adicionando Menu como dependência para ter apenas uma lista
        private Menu menu;

        public ManutencaoCliente(Menu menu, List<Cliente> clientes)
        {
            this.menu = menu;
            this.clientes = clientes ?? new List<Cliente>();
        }

        public void Cadastra()
        {
            Console.Clear();
            menu.ExibirLogo();
            Console.WriteLine("\nDigite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Cliente cliente = new Cliente(nome, cpf);
            clientes.Add(cliente);
            Console.WriteLine($"O cliente {nome} foi incluído com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

        public void Listar()
        {
            Console.Clear();
            menu.ExibirLogo();
            Console.WriteLine("\nClientes cadastrados:\n");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
            Console.Clear();
            menu.ExibirLogo();
            menu.ExibirMenu();
        }
    }
}
