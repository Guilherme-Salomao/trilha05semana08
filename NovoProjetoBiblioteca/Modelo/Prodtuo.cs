using System.Text.Json.Serialization;

namespace Semana08_Classes.Modelo
{
    /// <summary>
    /// Representa um produto com código, nome, descrição, preço unitário e quantidade.
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Obtém ou define o código do produto.
        /// </summary>
        [JsonPropertyName("id")]
        public int Codigo { get; set; }
        [JsonPropertyName("title")]

        /// <summary>
        /// Obtém ou define o nome do produto.
        /// </summary>
        public string Nome { get; set; }
        [JsonPropertyName("description")]

        /// <summary>
        /// Obtém ou define a descrição do produto.
        /// </summary>
        public string Descricao { get; set; }
        [JsonPropertyName("price")]

        /// <summary>
        /// Obtém ou define o preço unitário do produto.
        /// </summary>
        public double PrecoUnitario { get; set; }

        /// <summary>
        /// Obtém ou define a quantidade do produto em estoque.
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Produto"/>.
        /// </summary>
        public Produto() { }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Produto"/> com o nome especificado.
        /// </summary>
        /// <param name="nome">O nome do produto.</param>
        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}

