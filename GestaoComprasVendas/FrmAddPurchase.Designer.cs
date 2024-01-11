namespace GestaoComprasVendas
{
    partial class FrmAddPurchase
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
            label2 = new Label();
            label4 = new Label();
            txtValue = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            cbxSupplier = new ComboBox();
            dgvProductsQuantitys = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            cbxProduct = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductsQuantitys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 325);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 378);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Supplier";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(20, 343);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(237, 23);
            txtValue.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(169, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(20, 449);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // cbxSupplier
            // 
            cbxSupplier.FormattingEnabled = true;
            cbxSupplier.Location = new Point(20, 396);
            cbxSupplier.Name = "cbxSupplier";
            cbxSupplier.Size = new Size(237, 23);
            cbxSupplier.TabIndex = 10;
            // 
            // dgvProductsQuantitys
            // 
            dgvProductsQuantitys.AllowUserToAddRows = false;
            dgvProductsQuantitys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsQuantitys.Location = new Point(337, 12);
            dgvProductsQuantitys.Name = "dgvProductsQuantitys";
            dgvProductsQuantitys.Size = new Size(562, 460);
            dgvProductsQuantitys.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 13;
            label3.Text = "Quantity";
            // 
            // cbxProduct
            // 
            cbxProduct.FormattingEnabled = true;
            cbxProduct.Location = new Point(12, 30);
            cbxProduct.Name = "cbxProduct";
            cbxProduct.Size = new Size(245, 23);
            cbxProduct.TabIndex = 14;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(12, 96);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(245, 23);
            nudQuantity.TabIndex = 15;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(169, 143);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(88, 34);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // FrmAddPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 504);
            Controls.Add(btnAddProduct);
            Controls.Add(nudQuantity);
            Controls.Add(cbxProduct);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvProductsQuantitys);
            Controls.Add(cbxSupplier);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "FrmAddPurchase";
            Text = "Add Purchase";
            ((System.ComponentModel.ISupportInitialize)dgvProductsQuantitys).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private TextBox txtValue;
        private Button btnAdd;
        private Button btnClear;
        private ComboBox cbxSupplier;
        private DataGridView dgvProductsQuantitys;
        private Label label1;
        private Label label3;
        private ComboBox cbxProduct;
        private NumericUpDown nudQuantity;
        private Button btnAddProduct;
    }
}