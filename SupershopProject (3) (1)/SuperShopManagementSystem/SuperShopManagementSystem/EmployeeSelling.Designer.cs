namespace SuperShopManagementSystem
{
    partial class FrmEmployeeSelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeSelling));
            this.lblSellingProducts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSellingProductBilling = new System.Windows.Forms.Label();
            this.btnSellingProductConfirmBill = new System.Windows.Forms.Button();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCatagoryRefresh = new System.Windows.Forms.Button();
            this.cmbSelectCatagory = new System.Windows.Forms.ComboBox();
            this.dgvOwnerProduct = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductSellingId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.dgvSellingProductAddProduct = new System.Windows.Forms.DataGridView();
            this.btnSellingProductAdd = new System.Windows.Forms.Button();
            this.txtSellingProductQuantity = new System.Windows.Forms.TextBox();
            this.txtSellingProductPrice = new System.Windows.Forms.TextBox();
            this.txtSellingProductName = new System.Windows.Forms.TextBox();
            this.txtSellingProductBillingNo = new System.Windows.Forms.TextBox();
            this.lblSellingProductName = new System.Windows.Forms.Label();
            this.lblSellingProductQuantity = new System.Windows.Forms.Label();
            this.lblSellingBillingNo = new System.Windows.Forms.Label();
            this.lblSellingProductPrice = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSellingDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSellingTime = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerProduct)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingProductAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSellingProducts
            // 
            this.lblSellingProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSellingProducts.AutoSize = true;
            this.lblSellingProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSellingProducts.Location = new System.Drawing.Point(561, 9);
            this.lblSellingProducts.Name = "lblSellingProducts";
            this.lblSellingProducts.Size = new System.Drawing.Size(269, 38);
            this.lblSellingProducts.TabIndex = 0;
            this.lblSellingProducts.Text = "Selling Products";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-6, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 656);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.lblSellingProductBilling);
            this.panel3.Controls.Add(this.btnSellingProductConfirmBill);
            this.panel3.Controls.Add(this.dgvBilling);
            this.panel3.Location = new System.Drawing.Point(526, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 620);
            this.panel3.TabIndex = 17;
            // 
            // lblSellingProductBilling
            // 
            this.lblSellingProductBilling.AutoSize = true;
            this.lblSellingProductBilling.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingProductBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingProductBilling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellingProductBilling.Location = new System.Drawing.Point(159, 14);
            this.lblSellingProductBilling.Name = "lblSellingProductBilling";
            this.lblSellingProductBilling.Size = new System.Drawing.Size(107, 25);
            this.lblSellingProductBilling.TabIndex = 20;
            this.lblSellingProductBilling.Text = "HISTORY";
            // 
            // btnSellingProductConfirmBill
            // 
            this.btnSellingProductConfirmBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSellingProductConfirmBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellingProductConfirmBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellingProductConfirmBill.Location = new System.Drawing.Point(153, 52);
            this.btnSellingProductConfirmBill.Name = "btnSellingProductConfirmBill";
            this.btnSellingProductConfirmBill.Size = new System.Drawing.Size(113, 38);
            this.btnSellingProductConfirmBill.TabIndex = 19;
            this.btnSellingProductConfirmBill.Text = "Add Sales";
            this.btnSellingProductConfirmBill.UseVisualStyleBackColor = false;
            this.btnSellingProductConfirmBill.Click += new System.EventHandler(this.btnSellingProductConfirmBill_Click);
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(14, 113);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.ReadOnly = true;
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.Height = 24;
            this.dgvBilling.Size = new System.Drawing.Size(403, 493);
            this.dgvBilling.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCatagoryRefresh);
            this.panel2.Controls.Add(this.cmbSelectCatagory);
            this.panel2.Controls.Add(this.dgvOwnerProduct);
            this.panel2.Location = new System.Drawing.Point(977, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 620);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search by Catagory";
            // 
            // btnCatagoryRefresh
            // 
            this.btnCatagoryRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCatagoryRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagoryRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatagoryRefresh.Location = new System.Drawing.Point(114, 3);
            this.btnCatagoryRefresh.Name = "btnCatagoryRefresh";
            this.btnCatagoryRefresh.Size = new System.Drawing.Size(113, 32);
            this.btnCatagoryRefresh.TabIndex = 19;
            this.btnCatagoryRefresh.Text = "Refresh";
            this.btnCatagoryRefresh.UseVisualStyleBackColor = false;
            this.btnCatagoryRefresh.Click += new System.EventHandler(this.btnCatagoryRefresh_Click);
            // 
            // cmbSelectCatagory
            // 
            this.cmbSelectCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCatagory.FormattingEnabled = true;
            this.cmbSelectCatagory.Items.AddRange(new object[] {
            "Sweets",
            "Biscuit"});
            this.cmbSelectCatagory.Location = new System.Drawing.Point(201, 48);
            this.cmbSelectCatagory.Name = "cmbSelectCatagory";
            this.cmbSelectCatagory.Size = new System.Drawing.Size(135, 28);
            this.cmbSelectCatagory.TabIndex = 13;
            this.cmbSelectCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCatagory_SelectedIndexChanged);
            // 
            // dgvOwnerProduct
            // 
            this.dgvOwnerProduct.AllowUserToAddRows = false;
            this.dgvOwnerProduct.AllowUserToDeleteRows = false;
            this.dgvOwnerProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOwnerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerProduct.Location = new System.Drawing.Point(16, 85);
            this.dgvOwnerProduct.Name = "dgvOwnerProduct";
            this.dgvOwnerProduct.ReadOnly = true;
            this.dgvOwnerProduct.RowHeadersWidth = 51;
            this.dgvOwnerProduct.RowTemplate.Height = 24;
            this.dgvOwnerProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwnerProduct.Size = new System.Drawing.Size(320, 521);
            this.dgvOwnerProduct.TabIndex = 12;
            this.dgvOwnerProduct.DoubleClick += new System.EventHandler(this.dgvOwnerProduct_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.lblTotalAmount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtProductSellingId);
            this.panel4.Controls.Add(this.lblProductId);
            this.panel4.Controls.Add(this.dgvSellingProductAddProduct);
            this.panel4.Controls.Add(this.btnSellingProductAdd);
            this.panel4.Controls.Add(this.txtSellingProductQuantity);
            this.panel4.Controls.Add(this.txtSellingProductPrice);
            this.panel4.Controls.Add(this.txtSellingProductName);
            this.panel4.Controls.Add(this.txtSellingProductBillingNo);
            this.panel4.Controls.Add(this.lblSellingProductName);
            this.panel4.Controls.Add(this.lblSellingProductQuantity);
            this.panel4.Controls.Add(this.lblSellingBillingNo);
            this.panel4.Controls.Add(this.lblSellingProductPrice);
            this.panel4.Location = new System.Drawing.Point(13, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 620);
            this.panel4.TabIndex = 15;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(181, 591);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(14, 15);
            this.lblTotalAmount.TabIndex = 16;
            this.lblTotalAmount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grand Total Amount:";
            // 
            // txtProductSellingId
            // 
            this.txtProductSellingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSellingId.Location = new System.Drawing.Point(153, 49);
            this.txtProductSellingId.Name = "txtProductSellingId";
            this.txtProductSellingId.Size = new System.Drawing.Size(188, 27);
            this.txtProductSellingId.TabIndex = 14;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.Transparent;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductId.Location = new System.Drawing.Point(3, 52);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(95, 20);
            this.lblProductId.TabIndex = 13;
            this.lblProductId.Text = "Product Id";
            // 
            // dgvSellingProductAddProduct
            // 
            this.dgvSellingProductAddProduct.AllowUserToAddRows = false;
            this.dgvSellingProductAddProduct.AllowUserToDeleteRows = false;
            this.dgvSellingProductAddProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSellingProductAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellingProductAddProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.dgvSellingProductAddProduct.Location = new System.Drawing.Point(19, 280);
            this.dgvSellingProductAddProduct.Name = "dgvSellingProductAddProduct";
            this.dgvSellingProductAddProduct.ReadOnly = true;
            this.dgvSellingProductAddProduct.RowHeadersWidth = 51;
            this.dgvSellingProductAddProduct.RowTemplate.Height = 24;
            this.dgvSellingProductAddProduct.Size = new System.Drawing.Size(456, 288);
            this.dgvSellingProductAddProduct.TabIndex = 12;
            // 
            // btnSellingProductAdd
            // 
            this.btnSellingProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSellingProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellingProductAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellingProductAdd.Location = new System.Drawing.Point(197, 197);
            this.btnSellingProductAdd.Name = "btnSellingProductAdd";
            this.btnSellingProductAdd.Size = new System.Drawing.Size(107, 61);
            this.btnSellingProductAdd.TabIndex = 11;
            this.btnSellingProductAdd.Text = "Add Product";
            this.btnSellingProductAdd.UseVisualStyleBackColor = false;
            this.btnSellingProductAdd.Click += new System.EventHandler(this.btnSellingProductAdd_Click);
            // 
            // txtSellingProductQuantity
            // 
            this.txtSellingProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingProductQuantity.Location = new System.Drawing.Point(153, 166);
            this.txtSellingProductQuantity.Name = "txtSellingProductQuantity";
            this.txtSellingProductQuantity.Size = new System.Drawing.Size(188, 27);
            this.txtSellingProductQuantity.TabIndex = 10;
            // 
            // txtSellingProductPrice
            // 
            this.txtSellingProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingProductPrice.Location = new System.Drawing.Point(153, 127);
            this.txtSellingProductPrice.Name = "txtSellingProductPrice";
            this.txtSellingProductPrice.Size = new System.Drawing.Size(188, 27);
            this.txtSellingProductPrice.TabIndex = 9;
            // 
            // txtSellingProductName
            // 
            this.txtSellingProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingProductName.Location = new System.Drawing.Point(153, 85);
            this.txtSellingProductName.Name = "txtSellingProductName";
            this.txtSellingProductName.Size = new System.Drawing.Size(188, 27);
            this.txtSellingProductName.TabIndex = 8;
            // 
            // txtSellingProductBillingNo
            // 
            this.txtSellingProductBillingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingProductBillingNo.Location = new System.Drawing.Point(152, 14);
            this.txtSellingProductBillingNo.Name = "txtSellingProductBillingNo";
            this.txtSellingProductBillingNo.ReadOnly = true;
            this.txtSellingProductBillingNo.Size = new System.Drawing.Size(188, 27);
            this.txtSellingProductBillingNo.TabIndex = 7;
            // 
            // lblSellingProductName
            // 
            this.lblSellingProductName.AutoSize = true;
            this.lblSellingProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellingProductName.Location = new System.Drawing.Point(3, 88);
            this.lblSellingProductName.Name = "lblSellingProductName";
            this.lblSellingProductName.Size = new System.Drawing.Size(128, 20);
            this.lblSellingProductName.TabIndex = 4;
            this.lblSellingProductName.Text = "Product Name";
            // 
            // lblSellingProductQuantity
            // 
            this.lblSellingProductQuantity.AutoSize = true;
            this.lblSellingProductQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingProductQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellingProductQuantity.Location = new System.Drawing.Point(3, 169);
            this.lblSellingProductQuantity.Name = "lblSellingProductQuantity";
            this.lblSellingProductQuantity.Size = new System.Drawing.Size(79, 20);
            this.lblSellingProductQuantity.TabIndex = 6;
            this.lblSellingProductQuantity.Text = "Quantity";
            // 
            // lblSellingBillingNo
            // 
            this.lblSellingBillingNo.AutoSize = true;
            this.lblSellingBillingNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingBillingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingBillingNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellingBillingNo.Location = new System.Drawing.Point(3, 17);
            this.lblSellingBillingNo.Name = "lblSellingBillingNo";
            this.lblSellingBillingNo.Size = new System.Drawing.Size(91, 20);
            this.lblSellingBillingNo.TabIndex = 3;
            this.lblSellingBillingNo.Text = "Billing No";
            // 
            // lblSellingProductPrice
            // 
            this.lblSellingProductPrice.AutoSize = true;
            this.lblSellingProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingProductPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellingProductPrice.Location = new System.Drawing.Point(4, 130);
            this.lblSellingProductPrice.Name = "lblSellingProductPrice";
            this.lblSellingProductPrice.Size = new System.Drawing.Size(53, 20);
            this.lblSellingProductPrice.TabIndex = 5;
            this.lblSellingProductPrice.Text = "Price";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(1221, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 32);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSellingDate
            // 
            this.lblSellingDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSellingDate.AutoSize = true;
            this.lblSellingDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSellingDate.Location = new System.Drawing.Point(971, 5);
            this.lblSellingDate.Name = "lblSellingDate";
            this.lblSellingDate.Size = new System.Drawing.Size(54, 20);
            this.lblSellingDate.TabIndex = 23;
            this.lblSellingDate.Text = "Today";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(923, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1108, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time:";
            // 
            // lblSellingTime
            // 
            this.lblSellingTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSellingTime.AutoSize = true;
            this.lblSellingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSellingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSellingTime.Location = new System.Drawing.Point(1152, 5);
            this.lblSellingTime.Name = "lblSellingTime";
            this.lblSellingTime.Size = new System.Drawing.Size(41, 20);
            this.lblSellingTime.TabIndex = 26;
            this.lblSellingTime.Text = "time";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // PName
            // 
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // FrmEmployeeSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.lblSellingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSellingDate);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSellingProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmployeeSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM Supershop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmployeeSelling_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmployeeSelling_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingProductAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellingProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSellingProductBilling;
        private System.Windows.Forms.Button btnSellingProductConfirmBill;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCatagoryRefresh;
        private System.Windows.Forms.DataGridView dgvOwnerProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSellingProductAddProduct;
        private System.Windows.Forms.Button btnSellingProductAdd;
        private System.Windows.Forms.TextBox txtSellingProductQuantity;
        private System.Windows.Forms.TextBox txtSellingProductPrice;
        private System.Windows.Forms.TextBox txtSellingProductName;
        private System.Windows.Forms.TextBox txtSellingProductBillingNo;
        private System.Windows.Forms.Label lblSellingProductName;
        private System.Windows.Forms.Label lblSellingProductQuantity;
        private System.Windows.Forms.Label lblSellingBillingNo;
        private System.Windows.Forms.Label lblSellingProductPrice;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtProductSellingId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblSellingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSellingTime;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectCatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}