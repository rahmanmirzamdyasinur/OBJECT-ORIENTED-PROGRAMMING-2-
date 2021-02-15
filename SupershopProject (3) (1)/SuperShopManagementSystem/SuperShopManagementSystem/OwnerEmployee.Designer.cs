namespace SuperShopManagementSystem
{
    partial class FrmOwnerEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwnerEmployee));
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblOwnerEmployee = new System.Windows.Forms.Label();
            this.lblManageEmployee = new System.Windows.Forms.Label();
            this.pnlOwnerProduct = new System.Windows.Forms.Panel();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.dgvOwnerEmployee = new System.Windows.Forms.DataGridView();
            this.btnProductRefresh = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeAge = new System.Windows.Forms.Label();
            this.lblEmployeePassword = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlOwnerProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(586, 115);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(108, 42);
            this.btnProduct.TabIndex = 11;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblOwnerEmployee
            // 
            this.lblOwnerEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwnerEmployee.AutoSize = true;
            this.lblOwnerEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.lblOwnerEmployee.Location = new System.Drawing.Point(575, 11);
            this.lblOwnerEmployee.Name = "lblOwnerEmployee";
            this.lblOwnerEmployee.Size = new System.Drawing.Size(119, 38);
            this.lblOwnerEmployee.TabIndex = 10;
            this.lblOwnerEmployee.Text = "Owner";
            // 
            // lblManageEmployee
            // 
            this.lblManageEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageEmployee.AutoSize = true;
            this.lblManageEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageEmployee.Location = new System.Drawing.Point(527, 62);
            this.lblManageEmployee.Name = "lblManageEmployee";
            this.lblManageEmployee.Size = new System.Drawing.Size(230, 29);
            this.lblManageEmployee.TabIndex = 9;
            this.lblManageEmployee.Text = "Manage Employee";
            // 
            // pnlOwnerProduct
            // 
            this.pnlOwnerProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOwnerProduct.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlOwnerProduct.Controls.Add(this.txtEmployeePhone);
            this.pnlOwnerProduct.Controls.Add(this.txtSearchEmployee);
            this.pnlOwnerProduct.Controls.Add(this.lblEmployeePhone);
            this.pnlOwnerProduct.Controls.Add(this.txtEmployeePassword);
            this.pnlOwnerProduct.Controls.Add(this.dgvOwnerEmployee);
            this.pnlOwnerProduct.Controls.Add(this.btnProductRefresh);
            this.pnlOwnerProduct.Controls.Add(this.btnEmployeeDelete);
            this.pnlOwnerProduct.Controls.Add(this.btnEmployeeUpdate);
            this.pnlOwnerProduct.Controls.Add(this.btnEmployeeAdd);
            this.pnlOwnerProduct.Controls.Add(this.txtEmployeeAge);
            this.pnlOwnerProduct.Controls.Add(this.txtEmployeeName);
            this.pnlOwnerProduct.Controls.Add(this.txtEmployeeId);
            this.pnlOwnerProduct.Controls.Add(this.lblEmployeeAge);
            this.pnlOwnerProduct.Controls.Add(this.lblEmployeePassword);
            this.pnlOwnerProduct.Controls.Add(this.lblEmployeeName);
            this.pnlOwnerProduct.Controls.Add(this.lblEmployeeId);
            this.pnlOwnerProduct.Location = new System.Drawing.Point(25, 173);
            this.pnlOwnerProduct.Name = "pnlOwnerProduct";
            this.pnlOwnerProduct.Size = new System.Drawing.Size(1288, 527);
            this.pnlOwnerProduct.TabIndex = 8;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.Location = new System.Drawing.Point(228, 270);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(235, 27);
            this.txtEmployeePhone.TabIndex = 24;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(891, 48);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(235, 27);
            this.txtSearchEmployee.TabIndex = 23;
            this.txtSearchEmployee.Text = "Enter Employee Id";
            this.txtSearchEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchEmployee_MouseClick);
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhone.Location = new System.Drawing.Point(33, 263);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(104, 29);
            this.lblEmployeePhone.TabIndex = 22;
            this.lblEmployeePhone.Text = "PHONE";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword.Location = new System.Drawing.Point(228, 159);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(235, 27);
            this.txtEmployeePassword.TabIndex = 20;
            // 
            // dgvOwnerEmployee
            // 
            this.dgvOwnerEmployee.AllowUserToAddRows = false;
            this.dgvOwnerEmployee.AllowUserToDeleteRows = false;
            this.dgvOwnerEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOwnerEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerEmployee.Location = new System.Drawing.Point(541, 83);
            this.dgvOwnerEmployee.Name = "dgvOwnerEmployee";
            this.dgvOwnerEmployee.ReadOnly = true;
            this.dgvOwnerEmployee.RowHeadersWidth = 51;
            this.dgvOwnerEmployee.RowTemplate.Height = 24;
            this.dgvOwnerEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwnerEmployee.Size = new System.Drawing.Size(716, 419);
            this.dgvOwnerEmployee.TabIndex = 19;
            this.dgvOwnerEmployee.DoubleClick += new System.EventHandler(this.dgvOwnerEmployee_DoubleClick);
            // 
            // btnProductRefresh
            // 
            this.btnProductRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnProductRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductRefresh.Location = new System.Drawing.Point(1144, 45);
            this.btnProductRefresh.Name = "btnProductRefresh";
            this.btnProductRefresh.Size = new System.Drawing.Size(113, 32);
            this.btnProductRefresh.TabIndex = 18;
            this.btnProductRefresh.Text = "Refresh";
            this.btnProductRefresh.UseVisualStyleBackColor = false;
            this.btnProductRefresh.Click += new System.EventHandler(this.btnProductRefresh_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeDelete.Location = new System.Drawing.Point(333, 460);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(133, 42);
            this.btnEmployeeDelete.TabIndex = 16;
            this.btnEmployeeDelete.Text = "DELETE";
            this.btnEmployeeDelete.UseVisualStyleBackColor = false;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(175, 460);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(144, 42);
            this.btnEmployeeUpdate.TabIndex = 15;
            this.btnEmployeeUpdate.Text = "UPDATE";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeAdd.Location = new System.Drawing.Point(38, 460);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(126, 42);
            this.btnEmployeeAdd.TabIndex = 14;
            this.btnEmployeeAdd.Text = "ADD";
            this.btnEmployeeAdd.UseVisualStyleBackColor = false;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmployeeAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeAge.Location = new System.Drawing.Point(227, 210);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(235, 27);
            this.txtEmployeeAge.TabIndex = 12;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(227, 105);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(235, 27);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(227, 50);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(235, 27);
            this.txtEmployeeId.TabIndex = 7;
            // 
            // lblEmployeeAge
            // 
            this.lblEmployeeAge.AutoSize = true;
            this.lblEmployeeAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAge.Location = new System.Drawing.Point(33, 210);
            this.lblEmployeeAge.Name = "lblEmployeeAge";
            this.lblEmployeeAge.Size = new System.Drawing.Size(65, 29);
            this.lblEmployeeAge.TabIndex = 6;
            this.lblEmployeeAge.Text = "AGE";
            // 
            // lblEmployeePassword
            // 
            this.lblEmployeePassword.AutoSize = true;
            this.lblEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePassword.Location = new System.Drawing.Point(33, 159);
            this.lblEmployeePassword.Name = "lblEmployeePassword";
            this.lblEmployeePassword.Size = new System.Drawing.Size(159, 29);
            this.lblEmployeePassword.TabIndex = 3;
            this.lblEmployeePassword.Text = "PASSWORD";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(33, 105);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(86, 29);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "NAME";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(33, 50);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(38, 29);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "ID";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1200, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 32);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmOwnerEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblOwnerEmployee);
            this.Controls.Add(this.lblManageEmployee);
            this.Controls.Add(this.pnlOwnerProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOwnerEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM Supershop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOwnerEmployee_FormClosed);
            this.Load += new System.EventHandler(this.FrmOwnerEmployee_Load);
            this.pnlOwnerProduct.ResumeLayout(false);
            this.pnlOwnerProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblOwnerEmployee;
        private System.Windows.Forms.Label lblManageEmployee;
        private System.Windows.Forms.Panel pnlOwnerProduct;
        private System.Windows.Forms.DataGridView dgvOwnerEmployee;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeAge;
        private System.Windows.Forms.Label lblEmployeePassword;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtEmployeePhone;
    }
}