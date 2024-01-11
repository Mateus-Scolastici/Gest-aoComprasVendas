namespace GestaoComprasVendas.Models
{
    public class PurchaseItems
    {
        public Guid PurchaseItemsId { get; set; }
        public Guid ProductId { get; set; }
        public Guid PurchaseId { get; set; }
        public Product Product { get; set; }
        public Purchase Purchase { get; set; }
        public int Quantity { get; set; }
    }
}
