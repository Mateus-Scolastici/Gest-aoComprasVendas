using GestaoComprasVendas.Context;
using GestaoComprasVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoComprasVendas
{
    public partial class FrmAddProduct : Form
    {
        private readonly OrganizatorContext _context;
        public FrmAddProduct(OrganizatorContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
            };

            _context.Products.Add(p);
            _context.SaveChanges();

            MessageBox.Show("Product add succesfully!");

            txtName.Text = "";
            txtPrice.Text = "";
        }
    }
}
