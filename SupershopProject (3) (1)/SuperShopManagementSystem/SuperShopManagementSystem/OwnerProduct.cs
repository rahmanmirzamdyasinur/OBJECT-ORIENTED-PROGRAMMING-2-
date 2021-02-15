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
    public partial class FrmOwnerProduct : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal DataTable Dt { get; set; }
        private Form1 Login { get; set; }
        public FrmOwnerProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            AutoProductIdGenerate();
        }

        public FrmOwnerProduct(Form1 login) : this()
        {
            this.Login = login; 
        }

        private void FrmOwnerProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOwnerCatagory ownerCatagory = new FrmOwnerCatagory(this);
            ownerCatagory.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOwnerEmployee ownerEmployee = new FrmOwnerEmployee(this);
            ownerEmployee.Visible = true;
        }

        private void btnSellsHistoty_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOwnerSellsHistory ownerSellsHistory = new FrmOwnerSellsHistory(this);
            ownerSellsHistory.Visible = true;
        }

        private void btnOwnership_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOwnerChangeOwnership changeOwnership  = new FrmOwnerChangeOwnership(this);
            changeOwnership.Visible = true;


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1(this);
            login.Visible = true;
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product;";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvOwnerProduct.DataSource = this.Ds.Tables[0];
        }

        private void cmbSelectCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Product where Catagory = '"+ this.cmbSelectCatagory.Text + "';";
            this.PopulateGridView(sql);
        }

        private bool IsProductAddValid()
        {
            if(String.IsNullOrEmpty(this.txtProductId.Text) || String.IsNullOrEmpty(this.txtProductName.Text) || String.IsNullOrEmpty(this.cmbProductCatagory.Text) || String.IsNullOrEmpty(this.txtProductBrand.Text) || String.IsNullOrEmpty(this.txtProductPrice.Text) || String.IsNullOrEmpty(this.txtProductQuantity.Text) || String.IsNullOrEmpty(this.txtProductMadeIn.Text))

            {
                return false;
            }
            else
            {
                return true;
            }
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
            
            this.Dt = new DataTable();
            Dt.Columns.Add("Catagory", typeof(string));
            Dt.Load(rdr);
            cmbProductCatagory.ValueMember = "Catagory";
            cmbProductCatagory.DataSource = Dt;
            cmbSelectCatagory.ValueMember = "Catagory";
            cmbSelectCatagory.DataSource = Dt;
            Sqlcon.Close();

        }

        private void FrmOwnerProduct_Load(object sender, EventArgs e)
        {
            
            this.CatagoryComboBox();

            string sql = "select * from Product;";
            this.PopulateGridView(sql);

        }


        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsProductAddValid())
                {
                    string sql = @"insert into Product values ('" + this.txtProductId.Text + "', '" + this.txtProductName.Text + "','" + this.cmbProductCatagory.Text + "'," +
                "" + "'" + this.txtProductBrand.Text + "'," + this.txtProductPrice.Text + "," + this.txtProductQuantity.Text + ", '" + this.txtProductMadeIn.Text + "');";

                    int count = this.Da.ExequteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Product Inserted Successfully.");

                        string sl = "select * from Product;";
                        this.PopulateGridView(sl);


                    }
                    else
                    {
                        MessageBox.Show("Product Inserted Failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill up the Boxes");
                }
            }
            catch
            {
                MessageBox.Show("Exception error");
            }


            AutoProductIdGenerate();

            this.txtProductName.Text = "";

            this.cmbProductCatagory.Text = "";
            this.txtProductBrand.Text = "";
            this.txtProductPrice.Text = "";

            this.txtProductQuantity.Text = "";
            this.txtProductMadeIn.Text = "";



        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvOwnerProduct.CurrentRow.Cells["Id"].Value.ToString();

                string sql = @"delete from Product where Id ='"+ id + "';";

                int count = this.Da.ExequteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Deleted");

                    string sl = "select * from Product;";
                    this.PopulateGridView(sl);
                }
                else
                    MessageBox.Show("Failed");
            }
            catch
            {
                MessageBox.Show("Error in Deleting");
            }


            AutoProductIdGenerate();

            this.txtProductName.Text = "";

            this.cmbProductCatagory.Text = "";
            this.txtProductBrand.Text = "";
            this.txtProductPrice.Text = "";

            this.txtProductQuantity.Text = "";
            this.txtProductMadeIn.Text = "";
        }

        private void dgvOwnerProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Text = this.dgvOwnerProduct.CurrentRow.Cells["Id"].Value.ToString();

            this.txtProductName.Text = this.dgvOwnerProduct.CurrentRow.Cells["Name"].Value.ToString();

            this.cmbProductCatagory.Text = this.dgvOwnerProduct.CurrentRow.Cells["Catagory"].Value.ToString();

            this.txtProductBrand.Text = this.dgvOwnerProduct.CurrentRow.Cells["Brand"].Value.ToString();

            this.txtProductPrice.Text = this.dgvOwnerProduct.CurrentRow.Cells["Price_Taka"].Value.ToString();

            this.txtProductQuantity.Text = this.dgvOwnerProduct.CurrentRow.Cells["Quantity"].Value.ToString();

            this.txtProductMadeIn.Text = this.dgvOwnerProduct.CurrentRow.Cells["Made"].Value.ToString();

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
             try
             {
                 string sql = @"update Product  set Name = '" + this.txtProductName.Text + "', Catagory = '" + this.cmbProductCatagory.Text + "', Brand = '" + this.txtProductBrand.Text + "',Price_Taka = " + this.txtProductPrice.Text + ", Quantity = " + this.txtProductQuantity.Text + ", Made = '" + this.txtProductMadeIn.Text + "'   where Id = '" + this.txtProductId.Text + "'; ";

                 int count = this.Da.ExequteUpdateQuery(sql);

                 if (count == 1)
                 {
                     MessageBox.Show("Product Updated Successfully.");

                    string sl = "select * from Product;";
                    this.PopulateGridView(sl);


                }
                 else
                 {
                     MessageBox.Show("Product Updated Failed.");
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show("Error"+ex.Message);
             }

             AutoProductIdGenerate();
             
             this.txtProductName.Text = "";

             this.cmbProductCatagory.Text = "";
             this.txtProductBrand.Text = "";
             this.txtProductPrice.Text = "";

             this.txtProductQuantity.Text = "";
            this.txtProductMadeIn.Text = "";
             

            
        }


        private void AutoProductIdGenerate()
        {
            string sql = "select Id from Product  Order by Id desc;";
            this.Dt = this.Da.ExecuteQueryTable(sql);
            string oldId = Dt.Rows[0][0].ToString();

            string[] temp = oldId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId = "P-" + (++serialNo).ToString("00");

            this.txtProductId.Text = newId;
        }
    }
}
