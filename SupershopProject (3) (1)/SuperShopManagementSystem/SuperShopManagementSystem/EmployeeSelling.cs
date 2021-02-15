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
    
    public partial class FrmEmployeeSelling : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal DataTable Dt { get; set; }

        private Form1 Login { get; set; }
        public FrmEmployeeSelling()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            AutoBillIdGenerate();
        }

        public FrmEmployeeSelling(Form1 login) : this()
        {
            this.Login = login;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1(this);
            login.Visible = true;
        }

        private void FrmEmployeeSelling_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCatagoryRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product;";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            
            this.dgvOwnerProduct.DataSource = this.Ds.Tables[0];
        }

       

        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private void CatagoryComboBox()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-C9KGQ9G\SQLEXPRESS;Initial Catalog=supershop_db;
                                                          Persist Security Info=True;User ID=sa;Password=AVIjit123");
            this.Sqlcon.Open();


            SqlCommand cmd = new SqlCommand("select Catagory from CatagoryTable;", Sqlcon);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Catagory", typeof(string));
            dt.Load(rdr);
            cmbSelectCatagory.ValueMember = "Catagory";
            cmbSelectCatagory.DataSource = dt;

            Sqlcon.Close();

        }


            private void FrmEmployeeSelling_Load(object sender, EventArgs e)
        {
            AutoBillIdGenerate();
            this.CatagoryComboBox();

            this.lblSellingDate.Text = DateTime.Today.Day.ToString("00") + "-" + DateTime.Today.Month.ToString("00") + "-" + DateTime.Today.Year.ToString();

            this.lblSellingTime.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00")  ;


            string sq = "select * from BillTable;";
            this.Ds = this.Da.ExecuteQuery(sq);

            this.dgvBilling.DataSource = this.Ds.Tables[0];

            string sql = "select * from Product;";
            this.PopulateGridView(sql);
        }

        private void dgvOwnerProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductSellingId.ReadOnly = true;
            this.txtProductSellingId.Text = this.dgvOwnerProduct.CurrentRow.Cells["Id"].Value.ToString();

            this.txtSellingProductName.ReadOnly = true;
            this.txtSellingProductName.Text = this.dgvOwnerProduct.CurrentRow.Cells["Name"].Value.ToString();

            this.txtSellingProductPrice.ReadOnly = true;
            this.txtSellingProductPrice.Text = this.dgvOwnerProduct.CurrentRow.Cells["Price_Taka"].Value.ToString();

            

        }
        double grandTotal = 0;
       
        private void btnSellingProductAdd_Click(object sender, EventArgs e)
        {
            try
            
            {
                if(this.txtSellingProductQuantity.Text != "")
                {

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvSellingProductAddProduct);

                    newRow.Cells[0].Value = txtProductSellingId.Text;
                    newRow.Cells[1].Value = txtSellingProductName.Text;
                    newRow.Cells[2].Value = txtSellingProductPrice.Text;
                    newRow.Cells[3].Value = txtSellingProductQuantity.Text;
                    newRow.Cells[4].Value = Convert.ToDouble(txtSellingProductPrice.Text) * Convert.ToDouble(txtSellingProductQuantity.Text);
                    double total = Convert.ToInt32(txtSellingProductPrice.Text) * Convert.ToInt32(txtSellingProductQuantity.Text);
                    
                    dgvSellingProductAddProduct.Rows.Add(newRow);

                    grandTotal = grandTotal + total;

                    this.lblTotalAmount.Text = grandTotal + " bdt";

                    AutoBillIdGenerate();
                    this.txtProductSellingId.Text = "";
                    this.txtSellingProductName.Text = "";
                    this.txtSellingProductPrice.Text = "";
                    this.txtSellingProductQuantity.Text = "";




                }
                else
                {
                    MessageBox.Show("Enter Proper Quantity");
                }
            }
            catch
            {

            }
            

            

        }

        private void btnSellingProductConfirmBill_Click(object sender, EventArgs e)
        {
            if(txtSellingProductBillingNo.Text == "")
            {
                MessageBox.Show("Billing No Missing.");
            }
            else
            {

                try
                {

                    double Total = Convert.ToDouble(this.txtSellingProductPrice.Text) * Convert.ToDouble(this.txtSellingProductQuantity.Text);

                    
                    string sql = @"insert into BillTable values ( '"+ this.txtSellingProductBillingNo.Text + "', '"+ this.txtSellingProductName.Text+"', "+ this.txtSellingProductPrice.Text + ", "+ this.txtSellingProductQuantity.Text + ", '"+ this.lblSellingDate.Text + "' , "+Total.ToString()+");";

                    int count = this.Da.ExequteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Product Billed Successfully.");

                        string sq = "select * from BillTable;";
                        this.Ds = this.Da.ExecuteQuery(sq);

                        this.dgvBilling.DataSource = this.Ds.Tables[0];

                        AutoBillIdGenerate();


                        txtProductSellingId.Text = "";
                        txtSellingProductName.Text = "";
                        txtSellingProductPrice.Text = "";
                        txtSellingProductQuantity.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Product billed Failed.");
                    }

                    Sqlcon.Close();

                }
                catch
                {
                    MessageBox.Show("Error");

                }
                
            }
        }

        private void AutoBillIdGenerate()
        {
            string sql = "select Bill_No from BillTable  order by Bill_No desc;";
            this.Dt = this.Da.ExecuteQueryTable(sql);
            string oldId = Dt.Rows[0][0].ToString();

            string[] temp = oldId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId = "B-" + (++serialNo).ToString("00");

            this.txtSellingProductBillingNo.Text = newId;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSelectCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Product where Catagory = '" + this.cmbSelectCatagory.Text + "';";
            this.PopulateGridView(sql);
        }
    }
}
