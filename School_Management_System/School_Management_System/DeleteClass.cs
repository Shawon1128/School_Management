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
    public partial class DeleteClass : Form
    {
        private DataAccess Da { get; set; }
        public DeleteClass()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Class_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvDeleteClass.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtNoOfStudent.Clear();
            this.txtNoOfChairs.Clear();
            this.txtNoOfTables.Clear();
            this.txtSection.Clear();
            this.txtRoomNo.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteClass.ClearSelection();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteClass.SelectedRows.Count < 1)

            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    //MessageBox.Show("No delete");
                    return;
                }

                var query = "delete from Class_Details where ID = '" + txtID.Text + "';";

                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)

                    MessageBox.Show("Data removed properly");

                else

                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();

                //this.ClearContent();
            }

            catch (Exception exc)

            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Class_Details where Name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured!", exc.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Class_Details where Name like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured!", exc.Message);
            }
        }

        private void dgvDeleteClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteClass.SelectedRows != null && dgvDeleteClass.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteClass.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteClass.CurrentRow.Cells[1].Value.ToString();

                string No_Of_Students = dgvDeleteClass.CurrentRow.Cells[2].Value.ToString();

                string No_Of_Chairs = dgvDeleteClass.CurrentRow.Cells[3].Value.ToString();

                string No_Of_Table = dgvDeleteClass.CurrentRow.Cells[4].Value.ToString();

                string Section = dgvDeleteClass.CurrentRow.Cells[5].Value.ToString();

                string Room_No = dgvDeleteClass.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtNoOfStudent.Text = No_Of_Students;

                txtNoOfChairs.Text = No_Of_Chairs;

                txtNoOfTables.Text = No_Of_Table;

                txtSection.Text = Section;

                txtRoomNo.Text = Room_No;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Class_Details c = new Class_Details();
            c.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
