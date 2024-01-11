using GestaoComprasVendas.Context;
using GestaoComprasVendas.Models;

namespace GestaoComprasVendas
{
    public partial class FrmAddClient : Form
    {
        private readonly OrganizatorContext _context;
        public FrmAddClient(OrganizatorContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            string postalCode = txtPostalCode.Text;

            Client c = new Client()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                PostalCode = new string(postalCode.Where(char.IsDigit).ToArray()),
                Phone = new string(phone.Where(char.IsDigit).ToArray()),
            };

            _context.Clients.Add(c);
            _context.SaveChanges();

            MessageBox.Show("Client add succesfully!");

            txtName.Text = "";
            txtPostalCode.Text = "";
            txtPhone.Text = "";
        }

        private void FrmAddClient_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPostalCode.Text = "";
            txtPhone.Text = "";
        }
    }
}
