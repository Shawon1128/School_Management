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
    public partial class Class_Details : Form
    {
        private DataAccess Da { get; set; }
        public Class_Details()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = "select * from Class_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvClassDetails.DataSource = ds.Tables[0];
        }
       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertClass ic = new InsertClass();
            ic.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClass uc = new UpdateClass();
            uc.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClass dc = new DeleteClass();
            dc.Show();
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
                string sql = "select * from Class_Details where ID = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Class_Details where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            AdminAccess a = new AdminAccess();
            a.Show();
            this.Hide();
        }
    }
}
