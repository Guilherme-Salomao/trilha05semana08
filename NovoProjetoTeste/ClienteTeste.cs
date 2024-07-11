using Semana08_Classes.Modelo;
using Xunit;

namespace Semana08_Teste
{
    public class ClienteTeste
    {
        [Fact]
        public void Cliente_Construtor_DeveInicializarComNomeECpf()
        {
            // Arrange
            string nome = "Guilherme Salomão";
            string cpf = "123.123.123-12";

            // Act
            Cliente cliente = new Cliente(nome, cpf);

            // Assert
            Assert.Equal(nome, cliente.Nome);
            Assert.Equal(cpf, cliente.Cpf);
        }

        [Fact]
        public void Cliente_ObterDescricao_DeveRetornarDescricaoCorreta()
        {
            // Arrange
            string nome = "João da Silva";
            string cpf = "123.456.789-00";
            Cliente cliente = new Cliente(nome, cpf);

            // Act
            string descricao = cliente.ObterDescricao();

            // Assert
            Assert.Equal($"Nome do Cliente: {nome}, CPF: {cpf}", descricao);
        }

        [Fact]
        public void Cliente_Construtor_DeveInicializarComStringsVazias()
        {
            // Arrange
            string nome = "";
            string cpf = "";

            // Act
            Cliente cliente = new Cliente(nome, cpf);

            // Assert
            Assert.Equal(nome, cliente.Nome);
            Assert.Equal(cpf, cliente.Cpf);
        }

        [Fact]
        public void Cliente_Construtor_DeveLancarExcecaoParaNomeNulo()
        {
            // Arrange
            string nome = null;
            string cpf = "123.456.789-00";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Cliente(nome, cpf));
        }

        [Fact]
        public void Cliente_Construtor_DeveLancarExcecaoParaCpfNulo()
        {
            // Arrange
            string nome = "João da Silva";
            string cpf = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Cliente(nome, cpf));
        }
    }
}