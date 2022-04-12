namespace Final643450079_3
{
    partial class Form1
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
            this.buttonPress_to_View_Information = new System.Windows.Forms.Button();
            this.textBoxProduct_Code = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnProduct_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label_Product_Code = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Confirm_Price = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPress_to_View_Information
            // 
            this.buttonPress_to_View_Information.Location = new System.Drawing.Point(574, 10);
            this.buttonPress_to_View_Information.Name = "buttonPress_to_View_Information";
            this.buttonPress_to_View_Information.Size = new System.Drawing.Size(152, 23);
            this.buttonPress_to_View_Information.TabIndex = 0;
            this.buttonPress_to_View_Information.Text = "Press to View Information";
            this.buttonPress_to_View_Information.UseVisualStyleBackColor = true;
            this.buttonPress_to_View_Information.Click += new System.EventHandler(this.buttonPress_to_View_Information_Click_1);
            // 
            // textBoxProduct_Code
            // 
            this.textBoxProduct_Code.Location = new System.Drawing.Point(676, 39);
            this.textBoxProduct_Code.Name = "textBoxProduct_Code";
            this.textBoxProduct_Code.ReadOnly = true;
            this.textBoxProduct_Code.Size = new System.Drawing.Size(332, 20);
            this.textBoxProduct_Code.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(676, 65);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(332, 20);
            this.textBoxDescription.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct_Code,
            this.ColumnDescription,
            this.ColumnPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 192);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ColumnProduct_Code
            // 
            this.ColumnProduct_Code.HeaderText = "Product Code";
            this.ColumnProduct_Code.Name = "ColumnProduct_Code";
            this.ColumnProduct_Code.ReadOnly = true;
            this.ColumnProduct_Code.ToolTipText = "1";
            this.ColumnProduct_Code.Width = 95;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 300;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(676, 91);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(332, 20);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label_Product_Code
            // 
            this.label_Product_Code.AutoSize = true;
            this.label_Product_Code.Location = new System.Drawing.Point(574, 42);
            this.label_Product_Code.Name = "label_Product_Code";
            this.label_Product_Code.Size = new System.Drawing.Size(72, 13);
            this.label_Product_Code.TabIndex = 14;
            this.label_Product_Code.Text = "Product Code";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(574, 68);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 15;
            this.label_Description.Text = "Description";
            // 
            // label_Confirm_Price
            // 
            this.label_Confirm_Price.AutoSize = true;
            this.label_Confirm_Price.Location = new System.Drawing.Point(574, 94);
            this.label_Confirm_Price.Name = "label_Confirm_Price";
            this.label_Confirm_Price.Size = new System.Drawing.Size(69, 13);
            this.label_Confirm_Price.TabIndex = 16;
            this.label_Confirm_Price.Text = "Confirm Price";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(574, 120);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(43, 13);
            this.label_Amount.TabIndex = 17;
            this.label_Amount.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(676, 117);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(332, 20);
            this.textBoxAmount.TabIndex = 18;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(859, 143);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(149, 23);
            this.buttonConfirm.TabIndex = 44;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(639, 192);
            this.dataGridView2.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ToolTipText = "1";
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Discount";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 506);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_Confirm_Price);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Product_Code);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxProduct_Code);
            this.Controls.Add(this.buttonPress_to_View_Information);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPress_to_View_Information;
        private System.Windows.Forms.TextBox textBoxProduct_Code;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label_Product_Code;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Confirm_Price;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

