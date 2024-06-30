using Semana08.Classes;
using System;

namespace Semana08.Modelos
{
    internal class ItemDePedido : Produto
    {
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }

        // Construtor
        public ItemDePedido(string nome, int quantidade, decimal precoUnitario) : base(nome)
        {
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public string ObterItemProduto()
        {
            return $"Nome do Produto: {Nome}, Preço Unitário: {PrecoUnitario} -- Quantidade: {Quantidade} -- Valor Total: {Subtotal}";
        }
    }
}



