namespace GestaoComprasVendas.Models
{
    public class Sale
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public ICollection<SaleItems> SaleItems { get; set; }
        public DateTime RegistryDate { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
