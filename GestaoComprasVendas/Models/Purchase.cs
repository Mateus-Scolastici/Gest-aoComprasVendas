namespace GestaoComprasVendas.Models
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public ICollection<PurchaseItems> PurchaseItems { get; set; }
        public DateTime RegistryDate { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
