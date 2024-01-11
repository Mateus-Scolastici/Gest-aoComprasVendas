using GestaoComprasVendas.Context;
using GestaoComprasVendas.Models;

namespace GestaoComprasVendas
{
    public partial class FrmAddPurchase : Form
    {
        private readonly OrganizatorContext _context;
        private List<Product> _products;

        private string _columnProduct = "Product";
        private string _columnQuantity = "Quantity";
        private string _columnPrice = "Price";
        private string _columnTotalAmount = "Total Amount";

        private decimal _totalAmount = 0;

        public FrmAddPurchase(OrganizatorContext context)
        {
            _context = context;
            InitializeComponent();

            cbxSupplier.DataSource = _context.Suppliers.ToList();
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "Id";

            _products = _context.Products.ToList();
            cbxProduct.DataSource = _products;
            cbxProduct.DisplayMember = "Name";
            cbxProduct.ValueMember = "Id";

            txtValue.Text = "0";

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvProductsQuantitys.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.Name = _columnProduct;
            colProductName.DataPropertyName = _columnProduct;
            colProductName.HeaderText = _columnProduct;
            dgvProductsQuantitys.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = _columnQuantity;
            colQuantity.DataPropertyName = _columnQuantity;
            colQuantity.HeaderText = _columnQuantity;
            dgvProductsQuantitys.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = _columnPrice;
            colPrice.DataPropertyName = _columnPrice;
            colPrice.HeaderText = _columnPrice;
            dgvProductsQuantitys.Columns.Add(colPrice);

            DataGridViewTextBoxColumn colTotalValue = new DataGridViewTextBoxColumn();
            colTotalValue.Name = _columnTotalAmount;
            colTotalValue.DataPropertyName = _columnTotalAmount;
            colTotalValue.HeaderText = _columnTotalAmount;
            dgvProductsQuantitys.Columns.Add(colTotalValue);

            dgvProductsQuantitys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal value = decimal.Parse(txtValue.Text);

            var purchase = new Purchase
            {
                Amount = value,
                SupplierId = (Guid)cbxSupplier.SelectedValue,
                RegistryDate = DateTime.Now,
                PurchaseItems = new List<PurchaseItems>()
            };

            foreach (DataGridViewRow row in dgvProductsQuantitys.Rows)
            {
                var productName = row.Cells[_columnProduct].Value.ToString();
                var product = _products.FirstOrDefault(p => p.Name == productName);
                int quantity = Convert.ToInt32(row.Cells[_columnQuantity].Value);

                var purchaseItem = new PurchaseItems
                {
                    ProductId = product.Id,
                    Quantity = quantity
                };

                purchase.PurchaseItems.Add(purchaseItem);
            }

            _context.Purchases.Add(purchase);
            _context.SaveChanges();

            MessageBox.Show("Purchase Added Successfully!");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)cbxProduct.SelectedItem;
            int quantity = Convert.ToInt32(nudQuantity.Value);
            decimal totalAmount = selectedProduct.Price * quantity;

            if (selectedProduct != null && quantity > 0)
            {
                dgvProductsQuantitys.Rows.Add(selectedProduct.Name, quantity, selectedProduct.Price, totalAmount);
            }

            _totalAmount += totalAmount;

            txtValue.Text = _totalAmount.ToString();
        }

    }
}
