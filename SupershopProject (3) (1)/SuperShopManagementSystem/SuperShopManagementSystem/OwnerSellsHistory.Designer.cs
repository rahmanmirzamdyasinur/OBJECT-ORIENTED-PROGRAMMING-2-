namespace SuperShopManagementSystem
{
    partial class FrmOwnerSellsHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwnerSellsHistory));
            this.pnlSellsHistory = new System.Windows.Forms.Panel();
            this.dgvSellsHistory = new System.Windows.Forms.DataGridView();
            this.lblSales = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblOwnership = new System.Windows.Forms.Label();
            this.lblSellsHistory = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Bill_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSellsHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSellsHistory
            // 
            this.pnlSellsHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSellsHistory.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlSellsHistory.Controls.Add(this.dgvSellsHistory);
            this.pnlSellsHistory.Controls.Add(this.lblSales);
            this.pnlSellsHistory.Location = new System.Drawing.Point(25, 173);
            this.pnlSellsHistory.Name = "pnlSellsHistory";
            this.pnlSellsHistory.Size = new System.Drawing.Size(1288, 527);
            this.pnlSellsHistory.TabIndex = 28;
            // 
            // dgvSellsHistory
            // 
            this.dgvSellsHistory.AllowUserToAddRows = false;
            this.dgvSellsHistory.AllowUserToDeleteRows = false;
            this.dgvSellsHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSellsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellsHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bill_No,
            this.BillName,
            this.BillPrice,
            this.BillQuantity,
            this.BillDate,
            this.BillTotal});
            this.dgvSellsHistory.Location = new System.Drawing.Point(23, 85);
            this.dgvSellsHistory.Name = "dgvSellsHistory";
            this.dgvSellsHistory.ReadOnly = true;
            this.dgvSellsHistory.RowHeadersWidth = 51;
            this.dgvSellsHistory.RowTemplate.Height = 24;
            this.dgvSellsHistory.Size = new System.Drawing.Size(1239, 420);
            this.dgvSellsHistory.TabIndex = 19;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(541, 39);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(122, 25);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Total Sales";
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(571, 115);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(104, 42);
            this.btnProduct.TabIndex = 24;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblOwnership
            // 
            this.lblOwnership.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwnership.AutoSize = true;
            this.lblOwnership.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnership.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnership.ForeColor = System.Drawing.Color.Transparent;
            this.lblOwnership.Location = new System.Drawing.Point(564, 11);
            this.lblOwnership.Name = "lblOwnership";
            this.lblOwnership.Size = new System.Drawing.Size(119, 38);
            this.lblOwnership.TabIndex = 23;
            this.lblOwnership.Text = "Owner";
            // 
            // lblSellsHistory
            // 
            this.lblSellsHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSellsHistory.AutoSize = true;
            this.lblSellsHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblSellsHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellsHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSellsHistory.Location = new System.Drawing.Point(543, 61);
            this.lblSellsHistory.Name = "lblSellsHistory";
            this.lblSellsHistory.Size = new System.Drawing.Size(160, 29);
            this.lblSellsHistory.TabIndex = 22;
            this.lblSellsHistory.Text = "Sells History";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1200, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 40);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Bill_No
            // 
            this.Bill_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bill_No.DataPropertyName = "Bill_No";
            this.Bill_No.HeaderText = "Bill No";
            this.Bill_No.MinimumWidth = 6;
            this.Bill_No.Name = "Bill_No";
            this.Bill_No.ReadOnly = true;
            // 
            // BillName
            // 
            this.BillName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillName.DataPropertyName = "Name";
            this.BillName.HeaderText = "Product Name";
            this.BillName.MinimumWidth = 6;
            this.BillName.Name = "BillName";
            this.BillName.ReadOnly = true;
            // 
            // BillPrice
            // 
            this.BillPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillPrice.DataPropertyName = "Price";
            this.BillPrice.HeaderText = "Price";
            this.BillPrice.MinimumWidth = 6;
            this.BillPrice.Name = "BillPrice";
            this.BillPrice.ReadOnly = true;
            // 
            // BillQuantity
            // 
            this.BillQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillQuantity.DataPropertyName = "Quantity";
            this.BillQuantity.HeaderText = "Quantity";
            this.BillQuantity.MinimumWidth = 6;
            this.BillQuantity.Name = "BillQuantity";
            this.BillQuantity.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillDate.DataPropertyName = "Date";
            this.BillDate.HeaderText = "Billing Date";
            this.BillDate.MinimumWidth = 6;
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // BillTotal
            // 
            this.BillTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillTotal.DataPropertyName = "Total";
            this.BillTotal.HeaderText = "Total Bill";
            this.BillTotal.MinimumWidth = 6;
            this.BillTotal.Name = "BillTotal";
            this.BillTotal.ReadOnly = true;
            // 
            // FrmOwnerSellsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlSellsHistory);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblOwnership);
            this.Controls.Add(this.lblSellsHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOwnerSellsHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM Supershop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOwnerSellsHistory_FormClosed);
            this.Load += new System.EventHandler(this.FrmOwnerSellsHistory_Load);
            this.pnlSellsHistory.ResumeLayout(false);
            this.pnlSellsHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellsHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSellsHistory;
        private System.Windows.Forms.DataGridView dgvSellsHistory;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblOwnership;
        private System.Windows.Forms.Label lblSellsHistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTotal;
    }
}