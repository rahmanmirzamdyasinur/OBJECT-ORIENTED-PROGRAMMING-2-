using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystem
{
   
    public partial class FrmOwnerSellsHistory : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        private FrmOwnerCatagory OwnerCatagory { get; set; }
        private FrmOwnerProduct OwnerProduct { get; set; }

        private FrmOwnerEmployee OwnerEmployee { get; set; }
        public FrmOwnerSellsHistory()
        {
            InitializeComponent();

            this.Da = new DataAccess();
        }

        public FrmOwnerSellsHistory(FrmOwnerProduct ownerProduct) : this()
        {
            this.OwnerProduct = ownerProduct;
        }

        public FrmOwnerSellsHistory(FrmOwnerCatagory ownerCatagory) : this()
        {
            this.OwnerCatagory = ownerCatagory;
        }

        public FrmOwnerSellsHistory(FrmOwnerEmployee ownerEmployee) : this()
        {
            this.OwnerEmployee = ownerEmployee;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.OwnerProduct.Show();
            this.Visible = false;
        }

        private void FrmOwnerSellsHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            this.OwnerCatagory.Show();
            this.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.OwnerEmployee.Show();
            this.Visible = false;
        }

        private void btnOwnership_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmOwnerChangeOwnership ownerChangeOwnership = new FrmOwnerChangeOwnership(this);
            ownerChangeOwnership.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1(this);
            login.Visible = true;
        }

        private void FrmOwnerSellsHistory_Load(object sender, EventArgs e)
        {
            string sql = "select * from BillTable;";
            dgvSellsHistory.AutoGenerateColumns = false;
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvSellsHistory.DataSource = this.Ds.Tables[0];
        }

        
    }
}
