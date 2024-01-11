namespace GestaoComprasVendas
{
    partial class FrmAddSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            cbxName = new ComboBox();
            cbxClient = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            nudQuantity = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            txtAmount = new TextBox();
            btnAddProduct = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(313, 26);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(572, 482);
            dgvProducts.TabIndex = 11;
            // 
            // cbxName
            // 
            cbxName.FormattingEnabled = true;
            cbxName.Location = new Point(12, 27);
            cbxName.Name = "cbxName";
            cbxName.Size = new Size(229, 23);
            cbxName.TabIndex = 0;
            // 
            // cbxClient
            // 
            cbxClient.FormattingEnabled = true;
            cbxClient.Location = new Point(12, 420);
            cbxClient.Name = "cbxClient";
            cbxClient.Size = new Size(229, 23);
            cbxClient.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(12, 101);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(229, 23);
            nudQuantity.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 314);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 402);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Client";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(12, 332);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(229, 23);
            txtAmount.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(154, 153);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(87, 38);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(172, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 38);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 470);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 38);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmAddSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 532);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnAddProduct);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nudQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxClient);
            Controls.Add(cbxName);
            Name = "FrmAddSale";
            Text = "Add Sale";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxName;
        private ComboBox cbxClient;
        private Label label1;
        private Label label2;
        private NumericUpDown nudQuantity;
        private Label label3;
        private Label label4;
        private TextBox txtAmount;
        private Button btnAddProduct;
        private Button btnAdd;
        private Button btnClear;
        private DataGridView dgvProducts;
    }
}