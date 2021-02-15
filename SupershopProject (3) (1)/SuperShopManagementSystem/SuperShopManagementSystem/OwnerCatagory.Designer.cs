namespace SuperShopManagementSystem
{
    partial class FrmOwnerCatagory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwnerCatagory));
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblOwnerCatagory = new System.Windows.Forms.Label();
            this.lblManageCatagory = new System.Windows.Forms.Label();
            this.pnlOwnerCatagory = new System.Windows.Forms.Panel();
            this.dgvOwnerCatagory = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCatagoryRefresh = new System.Windows.Forms.Button();
            this.cmbSelectCatagory = new System.Windows.Forms.ComboBox();
            this.btnCatagoryDelete = new System.Windows.Forms.Button();
            this.btnCatagoryUpdate = new System.Windows.Forms.Button();
            this.btnCatagoryAdd = new System.Windows.Forms.Button();
            this.txtCatagoryType = new System.Windows.Forms.TextBox();
            this.txtCatagoryName = new System.Windows.Forms.TextBox();
            this.txtCatagoryId = new System.Windows.Forms.TextBox();
            this.lblCatagoryType = new System.Windows.Forms.Label();
            this.lblCatagoryName = new System.Windows.Forms.Label();
            this.lblCatagoryId = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOwnerCatagory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerCatagory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProduct.Location = new System.Drawing.Point(592, 113);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(103, 42);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblOwnerCatagory
            // 
            this.lblOwnerCatagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwnerCatagory.AutoSize = true;
            this.lblOwnerCatagory.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerCatagory.ForeColor = System.Drawing.Color.Transparent;
            this.lblOwnerCatagory.Location = new System.Drawing.Point(585, 9);
            this.lblOwnerCatagory.Name = "lblOwnerCatagory";
            this.lblOwnerCatagory.Size = new System.Drawing.Size(119, 38);
            this.lblOwnerCatagory.TabIndex = 9;
            this.lblOwnerCatagory.Text = "Owner";
            // 
            // lblManageCatagory
            // 
            this.lblManageCatagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageCatagory.AutoSize = true;
            this.lblManageCatagory.BackColor = System.Drawing.Color.Transparent;
            this.lblManageCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageCatagory.Location = new System.Drawing.Point(537, 60);
            this.lblManageCatagory.Name = "lblManageCatagory";
            this.lblManageCatagory.Size = new System.Drawing.Size(217, 29);
            this.lblManageCatagory.TabIndex = 8;
            this.lblManageCatagory.Text = "Manage Catagory";
            // 
            // pnlOwnerCatagory
            // 
            this.pnlOwnerCatagory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOwnerCatagory.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlOwnerCatagory.Controls.Add(this.label1);
            this.pnlOwnerCatagory.Controls.Add(this.dgvOwnerCatagory);
            this.pnlOwnerCatagory.Controls.Add(this.btnCatagoryRefresh);
            this.pnlOwnerCatagory.Controls.Add(this.cmbSelectCatagory);
            this.pnlOwnerCatagory.Controls.Add(this.btnCatagoryDelete);
            this.pnlOwnerCatagory.Controls.Add(this.btnCatagoryUpdate);
            this.pnlOwnerCatagory.Controls.Add(this.btnCatagoryAdd);
            this.pnlOwnerCatagory.Controls.Add(this.txtCatagoryType);
            this.pnlOwnerCatagory.Controls.Add(this.txtCatagoryName);
            this.pnlOwnerCatagory.Controls.Add(this.txtCatagoryId);
            this.pnlOwnerCatagory.Controls.Add(this.lblCatagoryType);
            this.pnlOwnerCatagory.Controls.Add(this.lblCatagoryName);
            this.pnlOwnerCatagory.Controls.Add(this.lblCatagoryId);
            this.pnlOwnerCatagory.Location = new System.Drawing.Point(25, 171);
            this.pnlOwnerCatagory.Name = "pnlOwnerCatagory";
            this.pnlOwnerCatagory.Size = new System.Drawing.Size(1288, 527);
            this.pnlOwnerCatagory.TabIndex = 14;
            // 
            // dgvOwnerCatagory
            // 
            this.dgvOwnerCatagory.AllowUserToAddRows = false;
            this.dgvOwnerCatagory.AllowUserToDeleteRows = false;
            this.dgvOwnerCatagory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOwnerCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerCatagory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Catagory});
            this.dgvOwnerCatagory.Location = new System.Drawing.Point(546, 95);
            this.dgvOwnerCatagory.Name = "dgvOwnerCatagory";
            this.dgvOwnerCatagory.ReadOnly = true;
            this.dgvOwnerCatagory.RowHeadersWidth = 51;
            this.dgvOwnerCatagory.RowTemplate.Height = 24;
            this.dgvOwnerCatagory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwnerCatagory.Size = new System.Drawing.Size(716, 419);
            this.dgvOwnerCatagory.TabIndex = 19;
            this.dgvOwnerCatagory.DoubleClick += new System.EventHandler(this.dgvOwnerCatagory_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Catagory Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Catagory
            // 
            this.Catagory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Catagory.DataPropertyName = "Catagory";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.MinimumWidth = 6;
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            // 
            // btnCatagoryRefresh
            // 
            this.btnCatagoryRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCatagoryRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagoryRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatagoryRefresh.Location = new System.Drawing.Point(1149, 44);
            this.btnCatagoryRefresh.Name = "btnCatagoryRefresh";
            this.btnCatagoryRefresh.Size = new System.Drawing.Size(113, 32);
            this.btnCatagoryRefresh.TabIndex = 18;
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
            this.cmbSelectCatagory.Location = new System.Drawing.Point(882, 48);
            this.cmbSelectCatagory.Name = "cmbSelectCatagory";
            this.cmbSelectCatagory.Size = new System.Drawing.Size(235, 28);
            this.cmbSelectCatagory.TabIndex = 17;
            this.cmbSelectCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCatagory_SelectedIndexChanged);
            // 
            // btnCatagoryDelete
            // 
            this.btnCatagoryDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCatagoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagoryDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatagoryDelete.Location = new System.Drawing.Point(337, 460);
            this.btnCatagoryDelete.Name = "btnCatagoryDelete";
            this.btnCatagoryDelete.Size = new System.Drawing.Size(138, 42);
            this.btnCatagoryDelete.TabIndex = 16;
            this.btnCatagoryDelete.Text = "DELETE";
            this.btnCatagoryDelete.UseVisualStyleBackColor = false;
            this.btnCatagoryDelete.Click += new System.EventHandler(this.btnCatagoryDelete_Click);
            // 
            // btnCatagoryUpdate
            // 
            this.btnCatagoryUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCatagoryUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagoryUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatagoryUpdate.Location = new System.Drawing.Point(188, 460);
            this.btnCatagoryUpdate.Name = "btnCatagoryUpdate";
            this.btnCatagoryUpdate.Size = new System.Drawing.Size(143, 42);
            this.btnCatagoryUpdate.TabIndex = 15;
            this.btnCatagoryUpdate.Text = "UPDATE";
            this.btnCatagoryUpdate.UseVisualStyleBackColor = false;
            this.btnCatagoryUpdate.Click += new System.EventHandler(this.btnCatagoryUpdate_Click);
            // 
            // btnCatagoryAdd
            // 
            this.btnCatagoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCatagoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagoryAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatagoryAdd.Location = new System.Drawing.Point(38, 460);
            this.btnCatagoryAdd.Name = "btnCatagoryAdd";
            this.btnCatagoryAdd.Size = new System.Drawing.Size(126, 42);
            this.btnCatagoryAdd.TabIndex = 14;
            this.btnCatagoryAdd.Text = "ADD";
            this.btnCatagoryAdd.UseVisualStyleBackColor = false;
            this.btnCatagoryAdd.Click += new System.EventHandler(this.btnCatagoryAdd_Click);
            // 
            // txtCatagoryType
            // 
            this.txtCatagoryType.BackColor = System.Drawing.SystemColors.Info;
            this.txtCatagoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryType.Location = new System.Drawing.Point(227, 167);
            this.txtCatagoryType.Name = "txtCatagoryType";
            this.txtCatagoryType.Size = new System.Drawing.Size(235, 27);
            this.txtCatagoryType.TabIndex = 11;
            // 
            // txtCatagoryName
            // 
            this.txtCatagoryName.BackColor = System.Drawing.SystemColors.Info;
            this.txtCatagoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryName.Location = new System.Drawing.Point(227, 105);
            this.txtCatagoryName.Name = "txtCatagoryName";
            this.txtCatagoryName.Size = new System.Drawing.Size(235, 27);
            this.txtCatagoryName.TabIndex = 8;
            // 
            // txtCatagoryId
            // 
            this.txtCatagoryId.BackColor = System.Drawing.SystemColors.Info;
            this.txtCatagoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryId.Location = new System.Drawing.Point(227, 50);
            this.txtCatagoryId.Name = "txtCatagoryId";
            this.txtCatagoryId.Size = new System.Drawing.Size(235, 27);
            this.txtCatagoryId.TabIndex = 7;
            // 
            // lblCatagoryType
            // 
            this.lblCatagoryType.AutoSize = true;
            this.lblCatagoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCatagoryType.Location = new System.Drawing.Point(33, 167);
            this.lblCatagoryType.Name = "lblCatagoryType";
            this.lblCatagoryType.Size = new System.Drawing.Size(81, 29);
            this.lblCatagoryType.TabIndex = 4;
            this.lblCatagoryType.Text = "TYPE";
            // 
            // lblCatagoryName
            // 
            this.lblCatagoryName.AutoSize = true;
            this.lblCatagoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCatagoryName.Location = new System.Drawing.Point(33, 105);
            this.lblCatagoryName.Name = "lblCatagoryName";
            this.lblCatagoryName.Size = new System.Drawing.Size(154, 29);
            this.lblCatagoryName.TabIndex = 1;
            this.lblCatagoryName.Text = "CATAGORY";
            // 
            // lblCatagoryId
            // 
            this.lblCatagoryId.AutoSize = true;
            this.lblCatagoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagoryId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCatagoryId.Location = new System.Drawing.Point(33, 50);
            this.lblCatagoryId.Name = "lblCatagoryId";
            this.lblCatagoryId.Size = new System.Drawing.Size(38, 29);
            this.lblCatagoryId.TabIndex = 0;
            this.lblCatagoryId.Text = "ID";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(1200, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 32);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(676, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search By Catagory";
            // 
            // FrmOwnerCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlOwnerCatagory);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblOwnerCatagory);
            this.Controls.Add(this.lblManageCatagory);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOwnerCatagory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM Supershop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOwnerCatagory_FormClosed);
            this.Load += new System.EventHandler(this.FrmOwnerCatagory_Load);
            this.pnlOwnerCatagory.ResumeLayout(false);
            this.pnlOwnerCatagory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerCatagory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblOwnerCatagory;
        private System.Windows.Forms.Label lblManageCatagory;
        private System.Windows.Forms.Panel pnlOwnerCatagory;
        private System.Windows.Forms.DataGridView dgvOwnerCatagory;
        private System.Windows.Forms.Button btnCatagoryRefresh;
        private System.Windows.Forms.ComboBox cmbSelectCatagory;
        private System.Windows.Forms.Button btnCatagoryDelete;
        private System.Windows.Forms.Button btnCatagoryUpdate;
        private System.Windows.Forms.Button btnCatagoryAdd;
        private System.Windows.Forms.TextBox txtCatagoryType;
        private System.Windows.Forms.TextBox txtCatagoryName;
        private System.Windows.Forms.TextBox txtCatagoryId;
        private System.Windows.Forms.Label lblCatagoryType;
        private System.Windows.Forms.Label lblCatagoryName;
        private System.Windows.Forms.Label lblCatagoryId;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.Label label1;
    }
}