using Semana08.Main;
using Semana08_Classes.Modelo;

namespace Semana08.Manutencao
{
    /// <summary>
    /// Classe responsável pela manutenção de clientes, incluindo cadastro e listagem.
    /// </summary>
    internal class ManutencaoCliente
    {
        /// <summary>
        /// Lista de clientes.
        /// </summary>
        //RECUPERANDO A LISTA
        private List<Cliente> clientes;

        /// <summary>
        /// Menu principal, usado para exibir a interface do usuário.
        /// </summary>
        // Adicionando Menu como dependência para ter apenas uma lista
        private Menu menu;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ManutencaoCliente"/> com o menu e a lista de clientes especificados.
        /// </summary>
        /// <param name="menu">O menu principal.</param>
        /// <param name="clientes">A lista de clientes.</param>
        public ManutencaoCliente(Menu menu, List<Cliente> clientes)
        {
            this.menu = menu;
            this.clientes = clientes ?? new List<Cliente>();
        }

        /// <summary>
        /// Cadastra um novo cliente, solicitando o nome e o CPF.
        /// </summary>
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

        /// <summary>
        /// Lista todos os clientes cadastrados, exibindo o nome e o CPF.
        /// </summary>
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
