using Microsoft.Extensions.DependencyInjection;

namespace GestaoComprasVendas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddClient = Program.ServiceProvider.GetRequiredService<FrmAddClient>();
            frmAddClient.MdiParent = this;
            frmAddClient.Show();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddSupplier = Program.ServiceProvider.GetRequiredService<FrmAddSupplier>();
            frmAddSupplier.MdiParent = this;
            frmAddSupplier.Show();
        }

        private void insertPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddPurchase = Program.ServiceProvider.GetRequiredService<FrmAddPurchase>();
            frmAddPurchase.MdiParent = this;
            frmAddPurchase.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddProduct = Program.ServiceProvider.GetRequiredService<FrmAddProduct>();
            frmAddProduct.MdiParent = this;
            frmAddProduct.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void insertSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddSale = Program.ServiceProvider.GetRequiredService<FrmAddSale>();
            frmAddSale.MdiParent = this;
            frmAddSale.Show();
        }

        private void balanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmSalesMinusPurchases = Program.ServiceProvider.GetRequiredService<FrmSalesMinusPurchases>();
            frmSalesMinusPurchases.MdiParent = this;
            frmSalesMinusPurchases.Show();
        }
    }
}
