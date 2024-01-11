using GestaoComprasVendas.Context;
using GestaoComprasVendas.Models;

namespace GestaoComprasVendas
{
    public partial class FrmAddSale : Form
    {
        private readonly OrganizatorContext _context;
        private List<Product> _products;

        private string _columnProduct = "Product";
        private string _columnQuantity = "Quantity";
        private string _columnPrice = "Price";
        private string _columnTotalAmount = "Total Amount";

        private decimal _totalAmount = 0;

        public FrmAddSale(OrganizatorContext context)
        {
            _context = context;
            InitializeComponent();

            _products = _context.Products.ToList();
            cbxName.DataSource = _products;
            cbxName.DisplayMember = "Name";
            cbxName.ValueMember = "Id";

            cbxClient.DataSource = _context.Clients.ToList();
            cbxClient.DisplayMember = "Name";
            cbxClient.ValueMember = "Id";

            txtAmount.Text = "0";

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.Name = _columnProduct;
            colProductName.DataPropertyName = _columnProduct;
            colProductName.HeaderText = _columnProduct;
            dgvProducts.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = _columnQuantity;
            colQuantity.DataPropertyName = _columnQuantity;
            colQuantity.HeaderText = _columnQuantity;
            dgvProducts.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = _columnPrice;
            colPrice.DataPropertyName = _columnPrice;
            colPrice.HeaderText = _columnPrice;
            dgvProducts.Columns.Add(colPrice);

            DataGridViewTextBoxColumn colTotalAmount = new DataGridViewTextBoxColumn();
            colTotalAmount.Name = _columnTotalAmount;
            colTotalAmount.DataPropertyName = _columnTotalAmount;
            colTotalAmount.HeaderText = _columnTotalAmount;
            dgvProducts.Columns.Add(colTotalAmount);

            dgvProducts.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)cbxName.SelectedItem;
            int quantity = Convert.ToInt32(nudQuantity.Value);
            decimal totalAmount = selectedProduct.Price * quantity;

            if (selectedProduct != null && quantity > 0)
            {
                dgvProducts.Rows.Add(selectedProduct.Name, quantity, selectedProduct.Price, totalAmount);
            }

            _totalAmount += totalAmount;
            txtAmount.Text = _totalAmount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(txtAmount.Text);

            var sale = new Sale
            {
                Amount = amount,
                ClientId = (Guid)cbxClient.SelectedValue,
                RegistryDate = DateTime.Now,
                SaleItems = new List<SaleItems>()
            };

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                var productName = row.Cells[_columnProduct].Value.ToString();
                var product = _products.FirstOrDefault(p => p.Name == productName);
                int quantity = Convert.ToInt32(row.Cells[_columnQuantity].Value);

                var saleItems = new SaleItems
                {
                    ProductId = product.Id,
                    Quantity = quantity,
                };

                sale.SaleItems.Add(saleItems);
            }

            _context.Sales.Add(sale);
            _context.SaveChanges();

            MessageBox.Show("Sale Added Succesfully");
        }
    }
}
