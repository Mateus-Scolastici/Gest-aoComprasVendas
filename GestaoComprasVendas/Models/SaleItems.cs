namespace GestaoComprasVendas.Models
{
    public class SaleItems
    {
        public Guid SaleItemsId { get; set; }
        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        public int Quantity { get; set; }
    }
}
