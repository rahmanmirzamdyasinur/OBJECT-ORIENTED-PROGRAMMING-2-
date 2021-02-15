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
    public partial class FrmOwnerEmployee : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        internal DataTable Dt { get; set; }
        private FrmOwnerProduct OwnerProduct { get; set; }
        private FrmOwnerCatagory OwnerCatagory { get; set; }

        
        public FrmOwnerEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            AutoEmployeeIdGenerate();
        }
        public FrmOwnerEmployee(FrmOwnerProduct ownerProduct) : this()
        {
            this.OwnerProduct = ownerProduct;
        }

        public FrmOwnerEmployee(FrmOwnerCatagory ownerCatagory) : this()
        {
            this.OwnerCatagory = ownerCatagory;
        }

        

        private void FrmOwnerEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.OwnerProduct.Show();
            this.Visible = false;
        }

        internal void btnCatagory_Click(object sender, EventArgs e)
        {
            
            
                this.OwnerCatagory.Show();
                this.Visible = false;
         

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

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserTable where Type = 'Employee';";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvOwnerEmployee.DataSource = this.Ds.Tables[0];
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            
            string sql = "select * from UserTable where Id = '"+this.txtSearchEmployee.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtSearchEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchEmployee.Text = "";
        }

        private bool IsEmployeeAddValid()
        {
            if (String.IsNullOrEmpty(this.txtEmployeeId.Text) || String.IsNullOrEmpty(this.txtEmployeeName.Text) || String.IsNullOrEmpty(this.txtEmployeePassword.Text) || String.IsNullOrEmpty(this.txtEmployeeAge.Text) || String.IsNullOrEmpty(this.txtEmployeePhone.Text))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (IsEmployeeAddValid())
                {
                    string sql = @"insert into UserTable values ('" + this.txtEmployeeId.Text + "','" + this.txtEmployeeName.Text + "','" + this.txtEmployeePassword.Text + "'," + this.txtEmployeeAge.Text + ",'Employee'," + this.txtEmployeePhone.Text + ");";

                    int count = this.Da.ExequteUpdateQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Employee Inserted Successfully.");

                        string sl = "select * from UserTable where Type = 'Employee';";
                        this.PopulateGridView(sl);


                    }
                    else
                    {
                        MessageBox.Show("Employee Inserted Failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill up the Boxes");
                }

                    
            }
            catch
            {
                MessageBox.Show("Error for adding Employee");
            }

            AutoEmployeeIdGenerate();

            this.txtEmployeeName.Text = "";
            this.txtEmployeePassword.Text = "";

            this.txtEmployeeAge.Text = "";
            this.txtEmployeePhone.Text = "";
            
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {

            try
            {
                var id = this.dgvOwnerEmployee.CurrentRow.Cells["Id"].Value.ToString();

                string sql = @"delete from UserTable where Id ='" + id + "';";

                int count = this.Da.ExequteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Deleted");

                    string sl = "select * from UserTable where Type = 'Employee';";
                    this.PopulateGridView(sl);

                }
                else
                    MessageBox.Show("Failed");
            }
            catch
            {
                MessageBox.Show("Error in Deleting");
            }


            AutoEmployeeIdGenerate();

            this.txtEmployeeName.Text = "";
            this.txtEmployeePassword.Text = "";

            this.txtEmployeeAge.Text = "";
            this.txtEmployeePhone.Text = "";
            
        }

       

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string sql =@"update UserTable
                set Name = '"+ this.txtEmployeeName.Text + "', Password = '"+ this.txtEmployeePassword.Text + "', Age = "+ this.txtEmployeeAge.Text + ", Type = 'Employee', Phone = "+ this.txtEmployeePhone.Text + " Where Id = '"+ this.txtEmployeeId.Text + "'; ";

                int count = this.Da.ExequteUpdateQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Employee Updated Successfully.");

                    string sl = "select * from UserTable where Type = 'Employee';";
                    this.PopulateGridView(sl);

                }
                else
                {
                    MessageBox.Show("Employee Updated Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            AutoEmployeeIdGenerate(); 

            this.txtEmployeeName.Text = "";
            this.txtEmployeePassword.Text = "";

            this.txtEmployeeAge.Text = "";
            this.txtEmployeePhone.Text = "";
            

        }

        private void dgvOwnerEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Text = this.dgvOwnerEmployee.CurrentRow.Cells["Id"].Value.ToString();

            this.txtEmployeeName.Text = this.dgvOwnerEmployee.CurrentRow.Cells["Name"].Value.ToString();

            this.txtEmployeePassword.Text = this.dgvOwnerEmployee.CurrentRow.Cells["Password"].Value.ToString();

            this.txtEmployeeAge.Text = this.dgvOwnerEmployee.CurrentRow.Cells["Age"].Value.ToString();

            this.txtEmployeePhone.Text = this.dgvOwnerEmployee.CurrentRow.Cells["Phone"].Value.ToString();

            
        }

        private void AutoEmployeeIdGenerate()
        {
            string sql = "select Id from UserTable where Type = 'Employee' order by Id desc;";
            this.Dt = this.Da.ExecuteQueryTable(sql);
            string oldId = Dt.Rows[0][0].ToString();

            string[] temp = oldId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId = "E-" + (++serialNo).ToString("000");

            this.txtEmployeeId.Text = newId;
        }

        private void FrmOwnerEmployee_Load(object sender, EventArgs e)
        {
            string sql = "select * from UserTable where Type = 'Employee';";
            this.PopulateGridView(sql);
        }
    }
}
