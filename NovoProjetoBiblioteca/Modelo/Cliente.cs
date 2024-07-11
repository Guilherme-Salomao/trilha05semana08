namespace Semana08_Classes.Modelo
{
    /// <summary>
    /// Representa um cliente com informações básicas como nome, CPF, email, profissão, telefone e endereço.
    /// </summary>
    public class Cliente
    {
        // Atributos privados
        private string nome;
        private string cpf;

        /// <summary>
        /// Email do cliente.
        /// </summary>
        public string email;

        /// <summary>
        /// Profissão do cliente.
        /// </summary>
        public string profissao;

        /// <summary>
        /// Telefone do cliente.
        /// </summary>
        public string telefone;

        /// <summary>
        /// Endereço do cliente.
        /// </summary>
        Endereco endereco;

        /// <summary>
        /// Obtém ou define o nome do cliente.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o CPF do cliente.
        /// </summary>
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Cliente"/> com o nome e CPF especificados.
        /// </summary>
        /// <param name="nome">Nome do cliente.</param>
        /// <param name="cpf">CPF do cliente.</param>
        // Construtor
        public Cliente(string nome, string cpf)
        {
            if (nome == null) throw new ArgumentNullException(nameof(nome));
            if (cpf == null) throw new ArgumentNullException(nameof(cpf));

            Nome = nome;
            Cpf = cpf;
        }

        /// <summary>
        /// Retorna uma descrição do cliente, incluindo o nome e CPF.
        /// </summary>
        /// <returns>Uma string que representa a descrição do cliente.</returns>
        public string ObterDescricao()
        {
            return $"Nome do Cliente: {nome}, CPF: {cpf}";
        }
    }
}
