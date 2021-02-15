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
    public partial class FrmOwnerCatagory : Form
    {

        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal DataTable Dt { get; set; }
        private FrmOwnerProduct OwnerProduct{ get; set; }
        public FrmOwnerCatagory()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            AutoCatagoryIdGenerate();
        }

        public FrmOwnerCatagory(FrmOwnerProduct ownerProduct) : this()
        {
            this.OwnerProduct = ownerProduct;
        }

        private void FrmOwnerCatagory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.OwnerProduct.Show();
            this.Visible = false;
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
            FrmOwnerChangeOwnership ownerChangeOwnership = new FrmOwnerChangeOwnership(this);
            ownerChangeOwnership.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1(this);
            login.Visible = true;
        }

        private void btnCatagoryRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from CatagoryTable;";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvOwnerCatagory.DataSource = this.Ds.Tables[0];
        }

        private void cmbSelectCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select * from CatagoryTable where Catagory = '"+ this.cmbSelectCatagory.Text+ "';";
            this.PopulateGridView(sql);
        }

        private bool IsCatagoryAddValid()
        {
            if (String.IsNullOrEmpty(this.txtCatagoryId.Text) || String.IsNullOrEmpty(this.txtCatagoryName.Text) || String.IsNullOrEmpty(this.txtCatagoryType.Text)  )

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCatagoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsCatagoryAddValid())
                {
                    string sql = @"insert into CatagoryTable values ('" + this.txtCatagoryId.Text + "','" + this.txtCatagoryName.Text + "','" + this.txtCatagoryType.Text + "');";

                    int count = this.Da.ExequteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Catagory Inserted Successfully.");

                        string sl = "select * from CatagoryTable;";
                        this.PopulateGridView(sl);
                    }
                    else
                    {
                        MessageBox.Show("Catagory Inserted Failed.");
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

            AutoCatagoryIdGenerate();

            this.txtCatagoryName.Text = ""; 
            this.txtCatagoryType.Text = "";
            

        }

        private void btnCatagoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvOwnerCatagory.CurrentRow.Cells["Id"].Value.ToString();

                string sql = @"delete from CatagoryTable where Id ='" + id + "';";

                int count = this.Da.ExequteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Deleted");

                    string sl = "select * from CatagoryTable;";
                    this.PopulateGridView(sl);
                }
                else
                    MessageBox.Show("Failed");
            }
            catch
            {
                MessageBox.Show("Error in Deleting");
            }

            AutoCatagoryIdGenerate();

            this.txtCatagoryName.Text = "";
            this.txtCatagoryType.Text = "";
            
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

        private void FrmOwnerCatagory_Load(object sender, EventArgs e)
        {
            this.CatagoryComboBox();

            string sql = "select * from CatagoryTable;";
            this.PopulateGridView(sql);

        }

        private void btnCatagoryUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = @"update CatagoryTable
set Catagory = '"+ this.txtCatagoryName.Text + "', Type = '"+ this.txtCatagoryType.Text + "'  Where Id = '" + this.txtCatagoryId.Text + "';";

                int count = this.Da.ExequteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Catagory Updated Successfully.");

                    string sl = "select * from CatagoryTable;";
                    this.PopulateGridView(sl);
                }
                else
                {
                    MessageBox.Show("Catagory Updated Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            AutoCatagoryIdGenerate();

            this.txtCatagoryName.Text = "";
            this.txtCatagoryType.Text = "";
            
        }

        private void dgvOwnerCatagory_DoubleClick(object sender, EventArgs e)
        {
            this.txtCatagoryId.ReadOnly = true;
            this.txtCatagoryId.Text = this.dgvOwnerCatagory.CurrentRow.Cells["Id"].Value.ToString();

            this.txtCatagoryName.Text = this.dgvOwnerCatagory.CurrentRow.Cells["Catagory"].Value.ToString();

            this.txtCatagoryType.Text = this.dgvOwnerCatagory.CurrentRow.Cells["Type"].Value.ToString();
        }


        private void AutoCatagoryIdGenerate()
        {
            string sql = "select Id from CatagoryTable  order by Id desc;";
            this.Dt = this.Da.ExecuteQueryTable(sql);
            string oldId = Dt.Rows[0][0].ToString();

            string[] temp = oldId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId = "C-" + (++serialNo).ToString("00");

            this.txtCatagoryId.Text = newId;
        }
    }
}
