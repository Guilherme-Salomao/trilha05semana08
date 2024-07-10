
namespace Semana08_Classes.Modelo;

public class Pedido
{
    /// <summary>
    /// Representa um pedido contendo informações do cliente, data, itens e o valor total.
    /// </summary>

    /// <summary>
    /// Obtém ou define o cliente associado ao pedido.
    /// </summary>
    public Cliente Cliente { get; set; }

    /// <summary>
    /// Obtém ou define a data do pedido.
    /// </summary>
    public DateTime Data { get; set; }

    /// <summary>
    /// Obtém ou define a lista de itens do pedido.
    /// </summary>
    public List<ItemDePedido> Itens { get; set; }

    private decimal total;

    /// <summary>
    /// Obtém o valor total do pedido.
    /// </summary>
    public decimal Total
    {
        get
        {
            return total;
        }
    }

    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Pedido"/> com o cliente, data e itens especificados.
    /// </summary>
    /// <param name="cliente">O cliente associado ao pedido.</param>
    /// <param name="data">A data do pedido.</param>
    /// <param name="itens">A lista de itens do pedido.</param>
    public Pedido(Cliente cliente, DateTime data, List<ItemDePedido> itens)
    {
        Cliente = cliente;
        Data = data;
        Itens = itens ?? new List<ItemDePedido>();
        total = 0;
        foreach (var item in Itens)
        {
            total += item.Subtotal;
        }
    }

    /// <summary>
    /// Exibe as informações do pedido, incluindo cliente, data, itens e o valor total.
    /// </summary>
    public void ExibirPedido()
    {
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"Data do Pedido: {Data}");
        Console.WriteLine("Itens:");
        foreach (var item in Itens)
        {
            Console.WriteLine($"{item.Nome} - {item.Quantidade} x {item.PrecoUnitario:C} = {item.Subtotal:C}");
        }
        Console.WriteLine($"Total do Pedido: {Total:C}");
    }

    /// <summary>
    /// Adiciona um item ao pedido e atualiza o valor total.
    /// </summary>
    /// <param name="item">O item a ser adicionado ao pedido.</param>
    public void AdicionarItem(ItemDePedido item)
    {
        Itens.Add(item);
        total += item.Subtotal;
    }

    /// <summary>
    /// Remove um item do pedido e atualiza o valor total.
    /// </summary>
    /// <param name="item">O item a ser removido do pedido.</param>
    public void RemoverItem(ItemDePedido item)
    {
        Itens.Remove(item);
        total -= item.Subtotal;
    }
}
