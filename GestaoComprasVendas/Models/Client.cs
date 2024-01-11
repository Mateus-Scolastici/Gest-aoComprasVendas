namespace GestaoComprasVendas.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
