using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Employee_Details : Form
    {
        private DataAccess Da { get; set; }
        public Employee_Details()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            //this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from EmployeeDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvEmployeeDetails.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertEmployeeDetails ie = new InsertEmployeeDetails();
            ie.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeDetails ue = new UpdateEmployeeDetails();
            ue.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployeeDetails de = new DeleteEmployeeDetails();
            de.Show();
            this.Hide();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from EmployeeDetails where ID = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from EmployeeDetails where Name like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            AdminAccess a = new AdminAccess();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
