using GestaoComprasVendas.Context;
using GestaoComprasVendas.Models;
using System.Data;

namespace GestaoComprasVendas
{
    public partial class FrmAddSupplier : Form
    {
        private readonly OrganizatorContext _context;

        public FrmAddSupplier(OrganizatorContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            string postalCode = txtPostalCode.Text;

            Supplier s = new Supplier()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                PostalCode = new string(postalCode.Where(char.IsDigit).ToArray()),
                Phone = new string(phone.Where(char.IsDigit).ToArray()),
            };

            _context.Suppliers.Add(s);
            _context.SaveChanges();

            MessageBox.Show("Supplier add succesfully!");

            txtName.Text = "";
            txtPostalCode.Text = "";
            txtPhone.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPostalCode.Text = "";
            txtPhone.Text = "";
        }
    }
}
