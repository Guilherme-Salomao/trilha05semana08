
namespace Semana08_Classes.Modelo
{
    /// <summary>
    /// Representa um item de pedido, que é um produto com quantidade e preço unitário.
    /// </summary>
    public class ItemDePedido : Produto
    {
        /// <summary>
        /// Obtém ou define a quantidade do produto no pedido.
        /// </summary>
        public int Quantidade { get; set; }
        
        /// <summary>
        /// Obtém ou define o preço unitário do produto.
        /// </summary>
        public decimal PrecoUnitario { get; set; }

        /// <summary>
        /// Obtém o subtotal do item, calculado como a quantidade multiplicada pelo preço unitário.
        /// </summary>
        public decimal Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ItemDePedido"/> com o nome do produto, quantidade e preço unitário especificados.
        /// </summary>
        /// <param name="nome">Nome do produto.</param>
        /// <param name="quantidade">Quantidade do produto.</param>
        /// <param name="precoUnitario">Preço unitário do produto.</param>
        // Construtor
        public ItemDePedido(string nome, int quantidade, decimal precoUnitario) : base(nome)
        {
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        /// <summary>
        /// Retorna uma descrição do item de pedido, incluindo o nome do produto, preço unitário, quantidade e valor total.
        /// </summary>
        /// <returns>Uma string que representa a descrição do item de pedido.</returns>
        public string ObterItemProduto()
        {
            return $"Nome do Produto: {Nome}, Preço Unitário: {PrecoUnitario} -- Quantidade: {Quantidade} -- Valor Total: {Subtotal}";
        }
    }
}



