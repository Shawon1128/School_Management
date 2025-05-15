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
    public partial class Subject_Details : Form
    {
        private DataAccess Da { get; set; }
        public Subject_Details()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            //this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from SubjectDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvSubjectDetailsDetails.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_SubjectDetails i = new Insert_SubjectDetails();
            i.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSubjectDetails usd = new UpdateSubjectDetails();
            usd.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_SubjectDetails dsd = new Delete_SubjectDetails();
            dsd.Show();
            this.Hide();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from SubjectDetails where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from SubjectDetails where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
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
