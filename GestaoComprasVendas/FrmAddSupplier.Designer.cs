﻿namespace GestaoComprasVendas
{
    partial class FrmAddSupplier
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPostalCode = new MaskedTextBox();
            txtPhone = new MaskedTextBox();
            btnAdd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Postal Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 149);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 23);
            txtName.TabIndex = 3;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(27, 100);
            txtPostalCode.Mask = "00000-000";
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(265, 23);
            txtPostalCode.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(27, 167);
            txtPhone.Mask = "(00)00000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(265, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(219, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(27, 211);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FrmAddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 307);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtPhone);
            Controls.Add(txtPostalCode);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddSupplier";
            Text = "Add Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private MaskedTextBox txtPostalCode;
        private MaskedTextBox txtPhone;
        private Button btnAdd;
        private Button btnClear;
    }
}