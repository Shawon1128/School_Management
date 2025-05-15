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
    public partial class StudentDetails : Form
    {
        private DataAccess Da { get; set; }
        public StudentDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            //this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Student_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvStudentDetails.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Student_Details where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Student_Details where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertStudentDetails i = new InsertStudentDetails();
            i.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudentDetails u = new UpdateStudentDetails();
            u.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudentDetails d = new DeleteStudentDetails();
            d.Show();
            this.Hide();
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
