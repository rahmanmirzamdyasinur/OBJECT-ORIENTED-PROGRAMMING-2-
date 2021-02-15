using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperShopManagementSystem
{
    public partial class Form1 : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal DataTable Dt { get; set; }
        private FrmOwnerProduct OwnerProduct { get; set; }
        private FrmOwnerCatagory OwnerCatagory { get; set; }
        private FrmOwnerChangeOwnership OwnerChangeOwnership { get; set; }
        private FrmOwnerEmployee OwnerEmployee { get; set; }
        private FrmOwnerSellsHistory OwnerSellsHistory { get; set; }
        private FrmEmployeeSelling EmployeeSelling { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        public Form1(FrmOwnerProduct ownerProduct) : this()
        {
            this.OwnerProduct = ownerProduct;
        }

        public Form1(FrmOwnerCatagory ownerCatagory) : this()
        {
            this.OwnerCatagory = ownerCatagory;
        }

        public Form1(FrmOwnerChangeOwnership ownerChangeOwnership) : this()
        {
            this.OwnerChangeOwnership = ownerChangeOwnership;
        }

        public Form1(FrmOwnerEmployee ownerEmployee) : this()
        {
            this.OwnerEmployee = ownerEmployee;
        }

        public Form1(FrmOwnerSellsHistory ownerSellsHistory) : this()
        {
            this.OwnerSellsHistory = ownerSellsHistory;
        }

        public Form1(FrmEmployeeSelling employeeSelling) : this()
        {
            this.EmployeeSelling = employeeSelling;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = @"select * from UserTable where Id='"+ this.txtLoginId.Text+"' and Password='"+ this.txtLoginPassword.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                if (this.Ds.Tables[0].Rows[0][4].ToString() == "Owner")
                { 
                    this.Hide();
                    FrmOwnerProduct ownerProduct = new FrmOwnerProduct(this);
                    ownerProduct.Visible = true; 

                }
                else if (this.Ds.Tables[0].Rows[0][4].ToString() == "Employee")
                {
                    this.Hide();
                    FrmEmployeeSelling employeeSelling = new FrmEmployeeSelling(this);
                    employeeSelling.Visible = true;
                } 

            }
            else
            {
                MessageBox.Show("Enter valid id and password");
                txtLoginId.Text = "";
                txtLoginPassword.Text = "";

            }


            
                  
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoginId.Text = "";
            txtLoginPassword.Text = "";
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
