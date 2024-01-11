namespace GestaoComprasVendas.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<PurchaseItems> PurchaseItems { get; set;}
        public ICollection<SaleItems> SaleItems { get; set;}
    }
}
