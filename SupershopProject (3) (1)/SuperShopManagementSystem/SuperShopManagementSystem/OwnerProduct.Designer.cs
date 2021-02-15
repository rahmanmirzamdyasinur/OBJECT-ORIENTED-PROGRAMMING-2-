namespace SuperShopManagementSystem
{
    partial class FrmOwnerProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwnerProduct));
            this.pnlOwnerProduct = new System.Windows.Forms.Panel();
            this.cmbSelectCatagory = new System.Windows.Forms.ComboBox();
            this.dgvOwnerProduct = new System.Windows.Forms.DataGridView();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.cmbSearchCatagory = new System.Windows.Forms.ComboBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.cmbProductCatagory = new System.Windows.Forms.ComboBox();
            this.txtProductBrand = new System.Windows.Forms.TextBox();
            this.txtProductMadeIn = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductMadeIn = new System.Windows.Forms.Label();
            this.lblProductCatagory = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblManageProduct = new System.Windows.Forms.Label();
            this.lblOwnerProduct = new System.Windows.Forms.Label();
            this.btnCatagory = new System.Windows.Forms.Button();
            this.btnSellsHistoty = new System.Windows.Forms.Button();
            this.btnOwnership = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOwnerProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOwnerProduct
            // 
            this.pnlOwnerProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOwnerProduct.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlOwnerProduct.Controls.Add(this.label1);
            this.pnlOwnerProduct.Controls.Add(this.cmbSelectCatagory);
            this.pnlOwnerProduct.Controls.Add(this.dgvOwnerProduct);
            this.pnlOwnerProduct.Controls.Add(this.btnProductRefresh);
            this.pnlOwnerProduct.Controls.Add(this.cmbSearchCatagory);
            this.pnlOwnerProduct.Controls.Add(this.btnProductDelete);
            this.pnlOwnerProduct.Controls.Add(this.btnProductUpdate);
            this.pnlOwnerProduct.Controls.Add(this.btnProductAdd);
            this.pnlOwnerProduct.Controls.Add(this.cmbProductCatagory);
            this.pnlOwnerProduct.Controls.Add(this.txtProductBrand);
            this.pnlOwnerProduct.Controls.Add(this.txtProductMadeIn);
            this.pnlOwnerProduct.Controls.Add(this.txtProductQuantity);
            this.pnlOwnerProduct.Controls.Add(this.txtProductPrice);
            this.pnlOwnerProduct.Controls.Add(this.txtProductName);
            this.pnlOwnerProduct.Controls.Add(this.txtProductId);
            this.pnlOwnerProduct.Controls.Add(this.lblProductBrand);
            this.pnlOwnerProduct.Controls.Add(this.lblProductPrice);
            this.pnlOwnerProduct.Controls.Add(this.lblProductMadeIn);
            this.pnlOwnerProduct.Controls.Add(this.lblProductCatagory);
            this.pnlOwnerProduct.Controls.Add(this.lblProductQuantity);
            this.pnlOwnerProduct.Controls.Add(this.lblProductName);
            this.pnlOwnerProduct.Controls.Add(this.lblProductId);
            this.pnlOwnerProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlOwnerProduct.Location = new System.Drawing.Point(25, 171);
            this.pnlOwnerProduct.Name = "pnlOwnerProduct";
            this.pnlOwnerProduct.Size = new System.Drawing.Size(1288, 527);
            this.pnlOwnerProduct.TabIndex = 0;
            // 
            // cmbSelectCatagory
            // 
            this.cmbSelectCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCatagory.FormattingEnabled = true;
            this.cmbSelectCatagory.Items.AddRange(new object[] {
            "Sweets",
            "Biscuit"});
            this.cmbSelectCatagory.Location = new System.Drawing.Point(887, 44);
            this.cmbSelectCatagory.Name = "cmbSelectCatagory";
            this.cmbSelectCatagory.Size = new System.Drawing.Size(235, 28);
            this.cmbSelectCatagory.TabIndex = 20;
            this.cmbSelectCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCatagory_SelectedIndexChanged);
            // 
            // dgvOwnerProduct
            // 
            this.dgvOwnerProduct.AllowUserToAddRows = false;
            this.dgvOwnerProduct.AllowUserToDeleteRows = false;
            this.dgvOwnerProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOwnerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerProduct.Location = new System.Drawing.Point(541, 83);
            this.dgvOwnerProduct.Name = "dgvOwnerProduct";
            this.dgvOwnerProduct.ReadOnly = true;
            this.dgvOwnerProduct.RowHeadersWidth = 51;
            this.dgvOwnerProduct.RowTemplate.Height = 24;
            this.dgvOwnerProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwnerProduct.Size = new System.Drawing.Size(716, 419);
            this.dgvOwnerProduct.TabIndex = 19;
            this.dgvOwnerProduct.DoubleClick += new System.EventHandler(this.dgvOwnerProduct_DoubleClick);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnProductRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductRefresh.Location = new System.Drawing.Point(1144, 41);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(113, 32);
            this.btnProductRefresh.TabIndex = 18;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = false;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // cmbSearchCatagory
            // 
            this.cmbSearchCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchCatagory.FormattingEnabled = true;
            this.cmbSearchCatagory.Location = new System.Drawing.Point(1503, 159);
            this.cmbSearchCatagory.Name = "cmbSearchCatagory";
            this.cmbSearchCatagory.Size = new System.Drawing.Size(235, 28);
            this.cmbSearchCatagory.TabIndex = 17;
            this.cmbSearchCatagory.Text = "Select Catagory";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductDelete.Location = new System.Drawing.Point(329, 460);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(134, 42);
            this.btnProductDelete.TabIndex = 16;
            this.btnProductDelete.Text = "DELETE";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductUpdate.Location = new System.Drawing.Point(177, 460);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(133, 42);
            this.btnProductUpdate.TabIndex = 15;
            this.btnProductUpdate.Text = "UPDATE";
            this.btnProductUpdate.UseVisualStyleBackColor = false;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductAdd.Location = new System.Drawing.Point(38, 460);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(126, 42);
            this.btnProductAdd.TabIndex = 14;
            this.btnProductAdd.Text = "ADD";
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // cmbProductCatagory
            // 
            this.cmbProductCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductCatagory.FormattingEnabled = true;
            this.cmbProductCatagory.Items.AddRange(new object[] {
            "Sweets",
            "Biscuit"});
            this.cmbProductCatagory.Location = new System.Drawing.Point(227, 159);
            this.cmbProductCatagory.Name = "cmbProductCatagory";
            this.cmbProductCatagory.Size = new System.Drawing.Size(235, 28);
            this.cmbProductCatagory.TabIndex = 13;
            // 
            // txtProductBrand
            // 
            this.txtProductBrand.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBrand.Location = new System.Drawing.Point(227, 210);
            this.txtProductBrand.Name = "txtProductBrand";
            this.txtProductBrand.Size = new System.Drawing.Size(235, 27);
            this.txtProductBrand.TabIndex = 12;
            // 
            // txtProductMadeIn
            // 
            this.txtProductMadeIn.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductMadeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductMadeIn.Location = new System.Drawing.Point(227, 377);
            this.txtProductMadeIn.Name = "txtProductMadeIn";
            this.txtProductMadeIn.Size = new System.Drawing.Size(235, 27);
            this.txtProductMadeIn.TabIndex = 11;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(227, 321);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(235, 27);
            this.txtProductQuantity.TabIndex = 10;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(227, 266);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(235, 27);
            this.txtProductPrice.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(227, 105);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(235, 27);
            this.txtProductName.TabIndex = 8;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(227, 50);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(235, 27);
            this.txtProductId.TabIndex = 7;
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBrand.Location = new System.Drawing.Point(33, 210);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(101, 29);
            this.lblProductBrand.TabIndex = 6;
            this.lblProductBrand.Text = "BRAND";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(33, 266);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(90, 29);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "PRICE";
            // 
            // lblProductMadeIn
            // 
            this.lblProductMadeIn.AutoSize = true;
            this.lblProductMadeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductMadeIn.Location = new System.Drawing.Point(33, 377);
            this.lblProductMadeIn.Name = "lblProductMadeIn";
            this.lblProductMadeIn.Size = new System.Drawing.Size(118, 29);
            this.lblProductMadeIn.TabIndex = 4;
            this.lblProductMadeIn.Text = "MADE IN";
            // 
            // lblProductCatagory
            // 
            this.lblProductCatagory.AutoSize = true;
            this.lblProductCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCatagory.Location = new System.Drawing.Point(33, 159);
            this.lblProductCatagory.Name = "lblProductCatagory";
            this.lblProductCatagory.Size = new System.Drawing.Size(154, 29);
            this.lblProductCatagory.TabIndex = 3;
            this.lblProductCatagory.Text = "CATAGORY";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(33, 321);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(144, 29);
            this.lblProductQuantity.TabIndex = 2;
            this.lblProductQuantity.Text = "QUANTITY";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(33, 105);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(86, 29);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "NAME";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(33, 50);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(38, 29);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "ID";
            // 
            // lblManageProduct
            // 
            this.lblManageProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageProduct.AutoSize = true;
            this.lblManageProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageProduct.Location = new System.Drawing.Point(531, 60);
            this.lblManageProduct.Name = "lblManageProduct";
            this.lblManageProduct.Size = new System.Drawing.Size(216, 29);
            this.lblManageProduct.TabIndex = 1;
            this.lblManageProduct.Text = "Manage Products";
            // 
            // lblOwnerProduct
            // 
            this.lblOwnerProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwnerProduct.AutoSize = true;
            this.lblOwnerProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerProduct.ForeColor = System.Drawing.Color.Transparent;
            this.lblOwnerProduct.Location = new System.Drawing.Point(575, 9);
            this.lblOwnerProduct.Name = "lblOwnerProduct";
            this.lblOwnerProduct.Size = new System.Drawing.Size(119, 38);
            this.lblOwnerProduct.TabIndex = 2;
            this.lblOwnerProduct.Text = "Owner";
            // 
            // btnCatagory
            // 
            this.btnCatagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCatagory.BackColor = System.Drawing.Color.Transparent;
            this.btnCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagory.Location = new System.Drawing.Point(378, 114);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(111, 42);
            this.btnCatagory.TabIndex = 3;
            this.btnCatagory.Text = "Catagory";
            this.btnCatagory.UseVisualStyleBackColor = false;
            this.btnCatagory.Click += new System.EventHandler(this.btnCatagory_Click);
            // 
            // btnSellsHistoty
            // 
            this.btnSellsHistoty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSellsHistoty.BackColor = System.Drawing.Color.Transparent;
            this.btnSellsHistoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellsHistoty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSellsHistoty.Location = new System.Drawing.Point(626, 114);
            this.btnSellsHistoty.Name = "btnSellsHistoty";
            this.btnSellsHistoty.Size = new System.Drawing.Size(157, 42);
            this.btnSellsHistoty.TabIndex = 5;
            this.btnSellsHistoty.Text = "Sells History";
            this.btnSellsHistoty.UseVisualStyleBackColor = false;
            this.btnSellsHistoty.Click += new System.EventHandler(this.btnSellsHistoty_Click);
            // 
            // btnOwnership
            // 
            this.btnOwnership.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOwnership.BackColor = System.Drawing.Color.Transparent;
            this.btnOwnership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnership.Location = new System.Drawing.Point(793, 113);
            this.btnOwnership.Name = "btnOwnership";
            this.btnOwnership.Size = new System.Drawing.Size(176, 42);
            this.btnOwnership.TabIndex = 6;
            this.btnOwnership.Text = "Ownership";
            this.btnOwnership.UseVisualStyleBackColor = false;
            this.btnOwnership.Click += new System.EventHandler(this.btnOwnership_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(499, 113);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(118, 42);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1200, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 32);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(683, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search By Catagory";
            // 
            // FrmOwnerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnOwnership);
            this.Controls.Add(this.btnSellsHistoty);
            this.Controls.Add(this.btnCatagory);
            this.Controls.Add(this.lblOwnerProduct);
            this.Controls.Add(this.lblManageProduct);
            this.Controls.Add(this.pnlOwnerProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOwnerProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM Supershop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOwnerProduct_FormClosed);
            this.Load += new System.EventHandler(this.FrmOwnerProduct_Load);
            this.pnlOwnerProduct.ResumeLayout(false);
            this.pnlOwnerProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOwnerProduct;
        private System.Windows.Forms.Label lblManageProduct;
        private System.Windows.Forms.Label lblOwnerProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductMadeIn;
        private System.Windows.Forms.Label lblProductCatagory;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnCatagory;
        private System.Windows.Forms.Button btnSellsHistoty;
        private System.Windows.Forms.Button btnOwnership;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.ComboBox cmbProductCatagory;
        private System.Windows.Forms.TextBox txtProductBrand;
        private System.Windows.Forms.TextBox txtProductMadeIn;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.ComboBox cmbSearchCatagory;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.DataGridView dgvOwnerProduct;
        private System.Windows.Forms.ComboBox cmbSelectCatagory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}