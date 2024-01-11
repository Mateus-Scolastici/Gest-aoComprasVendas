namespace GestaoComprasVendas.Models
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public List<Purchase> Purchases { get; set; }
    }
}
