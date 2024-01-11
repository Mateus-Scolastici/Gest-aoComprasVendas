namespace GestaoComprasVendas
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            addClientToolStripMenuItem = new ToolStripMenuItem();
            viewClientDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateClientToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            insertPurchaseToolStripMenuItem = new ToolStripMenuItem();
            viewPurchaseDetailsToolStripMenuItem = new ToolStripMenuItem();
            deletePurchaseToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            insertSaleToolStripMenuItem = new ToolStripMenuItem();
            viewSaleDetailsToolStripMenuItem = new ToolStripMenuItem();
            deleteSaleToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            addSupplierToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            balanceToolStripMenuItem = new ToolStripMenuItem();
            balanceToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(887, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem, productToolStripMenuItem, purchaseToolStripMenuItem, saleToolStripMenuItem, supplierToolStripMenuItem, exitToolStripMenuItem, balanceToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addClientToolStripMenuItem, viewClientDetailsToolStripMenuItem, updateClientToolStripMenuItem });
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(180, 22);
            clientToolStripMenuItem.Text = "Client";
            // 
            // addClientToolStripMenuItem
            // 
            addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            addClientToolStripMenuItem.Size = new Size(171, 22);
            addClientToolStripMenuItem.Text = "Add Client";
            addClientToolStripMenuItem.Click += addClientToolStripMenuItem_Click;
            // 
            // viewClientDetailsToolStripMenuItem
            // 
            viewClientDetailsToolStripMenuItem.Name = "viewClientDetailsToolStripMenuItem";
            viewClientDetailsToolStripMenuItem.Size = new Size(171, 22);
            viewClientDetailsToolStripMenuItem.Text = "View Client Details";
            // 
            // updateClientToolStripMenuItem
            // 
            updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            updateClientToolStripMenuItem.Size = new Size(171, 22);
            updateClientToolStripMenuItem.Text = "Update Client";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(180, 22);
            productToolStripMenuItem.Text = "Product";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(141, 22);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertPurchaseToolStripMenuItem, viewPurchaseDetailsToolStripMenuItem, deletePurchaseToolStripMenuItem });
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(180, 22);
            purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // insertPurchaseToolStripMenuItem
            // 
            insertPurchaseToolStripMenuItem.Name = "insertPurchaseToolStripMenuItem";
            insertPurchaseToolStripMenuItem.Size = new Size(188, 22);
            insertPurchaseToolStripMenuItem.Text = "Add Purchase";
            insertPurchaseToolStripMenuItem.Click += insertPurchaseToolStripMenuItem_Click;
            // 
            // viewPurchaseDetailsToolStripMenuItem
            // 
            viewPurchaseDetailsToolStripMenuItem.Name = "viewPurchaseDetailsToolStripMenuItem";
            viewPurchaseDetailsToolStripMenuItem.Size = new Size(188, 22);
            viewPurchaseDetailsToolStripMenuItem.Text = "View Purchase Details";
            // 
            // deletePurchaseToolStripMenuItem
            // 
            deletePurchaseToolStripMenuItem.Name = "deletePurchaseToolStripMenuItem";
            deletePurchaseToolStripMenuItem.Size = new Size(188, 22);
            deletePurchaseToolStripMenuItem.Text = "Delete Purchase";
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertSaleToolStripMenuItem, viewSaleDetailsToolStripMenuItem, deleteSaleToolStripMenuItem });
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(180, 22);
            saleToolStripMenuItem.Text = "Sale";
            // 
            // insertSaleToolStripMenuItem
            // 
            insertSaleToolStripMenuItem.Name = "insertSaleToolStripMenuItem";
            insertSaleToolStripMenuItem.Size = new Size(161, 22);
            insertSaleToolStripMenuItem.Text = "Add Sale";
            insertSaleToolStripMenuItem.Click += insertSaleToolStripMenuItem_Click;
            // 
            // viewSaleDetailsToolStripMenuItem
            // 
            viewSaleDetailsToolStripMenuItem.Name = "viewSaleDetailsToolStripMenuItem";
            viewSaleDetailsToolStripMenuItem.Size = new Size(161, 22);
            viewSaleDetailsToolStripMenuItem.Text = "View Sale Details";
            // 
            // deleteSaleToolStripMenuItem
            // 
            deleteSaleToolStripMenuItem.Name = "deleteSaleToolStripMenuItem";
            deleteSaleToolStripMenuItem.Size = new Size(161, 22);
            deleteSaleToolStripMenuItem.Text = "Delete Sale";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addSupplierToolStripMenuItem });
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(180, 22);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // addSupplierToolStripMenuItem
            // 
            addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            addSupplierToolStripMenuItem.Size = new Size(142, 22);
            addSupplierToolStripMenuItem.Text = "Add Supplier";
            addSupplierToolStripMenuItem.Click += addSupplierToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // balanceToolStripMenuItem
            // 
            balanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { balanceToolStripMenuItem1 });
            balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            balanceToolStripMenuItem.Size = new Size(180, 22);
            balanceToolStripMenuItem.Text = "Balance";
            // 
            // balanceToolStripMenuItem1
            // 
            balanceToolStripMenuItem1.Name = "balanceToolStripMenuItem1";
            balanceToolStripMenuItem1.Size = new Size(180, 22);
            balanceToolStripMenuItem1.Text = "Balance";
            balanceToolStripMenuItem1.Click += balanceToolStripMenuItem1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 505);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Balance Manager";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem insertPurchaseToolStripMenuItem;
        private ToolStripMenuItem viewPurchaseDetailsToolStripMenuItem;
        private ToolStripMenuItem deletePurchaseToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem insertSaleToolStripMenuItem;
        private ToolStripMenuItem viewSaleDetailsToolStripMenuItem;
        private ToolStripMenuItem deleteSaleToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem addClientToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem addSupplierToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem viewClientDetailsToolStripMenuItem;
        private ToolStripMenuItem updateClientToolStripMenuItem;
        private ToolStripMenuItem balanceToolStripMenuItem;
        private ToolStripMenuItem balanceToolStripMenuItem1;
    }
}
