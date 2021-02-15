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
    public partial class FrmOwnerChangeOwnership : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal DataTable Dt { get; set; }
        private FrmOwnerProduct OwnerProduct { get; set; }

        private FrmOwnerCatagory OwnerCatagory { get; set; }

        private FrmOwnerEmployee OwnerEmployee { get; set; }

        private FrmOwnerSellsHistory OwnerSellsHistory { get; set; }
        public FrmOwnerChangeOwnership()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            AutoOwnerIdGenerate();
        }

        public FrmOwnerChangeOwnership(FrmOwnerProduct ownerProduct) : this()
        {
            this.OwnerProduct = ownerProduct;
        }

        public FrmOwnerChangeOwnership(FrmOwnerCatagory ownerCatagory) : this()
        {
            this.OwnerCatagory = ownerCatagory;
        }

        public FrmOwnerChangeOwnership(FrmOwnerEmployee ownerEmployee) : this()
        {
            this.OwnerEmployee = ownerEmployee;
        }

        public FrmOwnerChangeOwnership(FrmOwnerSellsHistory ownerSellsHistory) : this()
        {
            this.OwnerSellsHistory = ownerSellsHistory;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.OwnerProduct.Show();
            this.Visible = false;
        }

        private void FrmOwnerChangeOwnership_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnSellsHistoty_Click(object sender, EventArgs e)
        {
            this.OwnerSellsHistory.Show();
            this.Visible= false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1(this);
            login.Visible = true;
        }

       

       

        private void FrmOwnerChangeOwnership_Load(object sender, EventArgs e)
        {
            string sql = "select * from UserTable where Type = 'Owner';";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvOwnership.DataSource = this.Ds.Tables[0];
        }


        private bool IsOwnerAddValid()
        {
            if (String.IsNullOrEmpty(this.txtOwnershipId.Text) || String.IsNullOrEmpty(this.txtOwnershipName.Text) || String.IsNullOrEmpty(this.txtOwnershipPassword.Text) || String.IsNullOrEmpty(this.txtOwnerhipAge.Text) || String.IsNullOrEmpty(this.txtOwnerPhone.Text))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnOwnershipAdd_Click(object sender, EventArgs e)
        {

            try
            {

                if (IsOwnerAddValid())
                {
                    string sql = @"insert into UserTable values ('" + this.txtOwnershipId.Text + "','" + this.txtOwnershipName.Text + "','" + this.txtOwnershipPassword.Text + "'," + this.txtOwnerhipAge.Text + ",'Owner'," + this.txtOwnerPhone.Text + ");";

                    int count = this.Da.ExequteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Owner Inserted Successfully.");

                        string sl = "select * from UserTable where Type = 'Owner';";
                        this.PopulateGridView(sl);

                    }
                    else
                    {
                        MessageBox.Show("Owner Inserted Failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill up the Boxes");
                }

                    
            }
            catch
            {
                MessageBox.Show("Error for adding Owner");
            }

            AutoOwnerIdGenerate();

            this.txtOwnershipName.Text = "";
            this.txtOwnershipPassword.Text = "";

            this.txtOwnerhipAge.Text = "";
            this.txtOwnerPhone.Text = "";
           

        }

        private void btnOwnershipDelete_Click(object sender, EventArgs e)
        {
            string Sql = @"select * from UserTable where Type ='Owner'  ";
            int coun = this.Da.ExequteUpdateQuery(Sql);

            if (coun != 1)
            {
                try
                {
                    var id = this.dgvOwnership.CurrentRow.Cells["Id"].Value.ToString();

                    string sql = @"delete from UserTable where Id ='" + id + "';";

                    int count = this.Da.ExequteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Deleted");

                        string sl = "select * from UserTable where Type = 'Owner';";
                        this.PopulateGridView(sl);

                    }
                    else
                        MessageBox.Show("Failed");
                }
                catch
                {
                    MessageBox.Show("Error in Deleting");
                }
            }
            else
            {
                MessageBox.Show("At first add one Owner than you can delete.");
            }

            AutoOwnerIdGenerate();

            this.txtOwnershipName.Text = "";
            this.txtOwnershipPassword.Text = "";

            this.txtOwnerhipAge.Text = "";
            this.txtOwnerPhone.Text = "";
            



        }

        private void btnOwnershipRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserTable where Type = 'Owner';";
            this.PopulateGridView(sql);
        }

        private void btnOwnershipUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"update UserTable
                set Name = '" + this.txtOwnershipName.Text + "', Password = '" + this.txtOwnershipPassword.Text + "', Age = " + this.txtOwnerhipAge.Text + ", Type = 'Owner', Phone = " + this.txtOwnerPhone.Text + " Where Id = '" + this.txtOwnershipId.Text + "'; ";
 
                int count = this.Da.ExequteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Owner Updated Successfully.");

                    string sl = "select * from UserTable where Type = 'Owner';";
                    this.PopulateGridView(sl);
                }
                else
                {
                    MessageBox.Show("Owner Updated Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }


            AutoOwnerIdGenerate();

            this.txtOwnershipName.Text = "";
            this.txtOwnershipPassword.Text = "";

            this.txtOwnerhipAge.Text = "";
            this.txtOwnerPhone.Text = "";
            

        }

        private void dgvOwnership_DoubleClick(object sender, EventArgs e)
        {
            this.txtOwnershipId.ReadOnly = true;
            this.txtOwnershipId.Text = this.dgvOwnership.CurrentRow.Cells["Id"].Value.ToString();

            this.txtOwnershipName.Text = this.dgvOwnership.CurrentRow.Cells["Name"].Value.ToString();

            this.txtOwnershipPassword.Text = this.dgvOwnership.CurrentRow.Cells["Password"].Value.ToString();

            this.txtOwnerhipAge.Text = this.dgvOwnership.CurrentRow.Cells["Age"].Value.ToString();

            this.txtOwnerPhone.Text = this.dgvOwnership.CurrentRow.Cells["Phone"].Value.ToString();
        }



        private void AutoOwnerIdGenerate()
        {
            string sql = "select Id from UserTable where Type = 'Owner' order by Id desc;";
            this.Dt = this.Da.ExecuteQueryTable(sql);
            string oldId = Dt.Rows[0][0].ToString();

            string[] temp = oldId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId = "O-" + (++serialNo).ToString("0000");

            this.txtOwnershipId.Text = newId;
        }
    }
}
