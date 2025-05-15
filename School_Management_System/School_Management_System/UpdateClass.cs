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
    public partial class UpdateClass : Form
    {
        private DataAccess Da { get; set; }
        public UpdateClass()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Class_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUpdateClass.DataSource = ds.Tables[0];
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
            this.dgvUpdateClass.ClearSelection();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtNoOfStudent.Text)
                || String.IsNullOrEmpty(this.txtNoOfChairs.Text)
                || String.IsNullOrEmpty(this.txtNoOfTables.Text) ||
                String.IsNullOrEmpty(this.txtSection.Text) || String.IsNullOrEmpty(this.txtRoomNo.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateClass.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Plaese select a Row first to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to change?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    var query = "UPDATE Class_Details SET Name = '" + txtName.Text + "',No_Of_Students = '" + txtNoOfStudent.Text + "',No_Of_Chairs = '" + txtNoOfChairs.Text + "',No_Of_Tables = '" + txtNoOfTables.Text + "',Section = '" + txtSection.Text + "',Room_No = '" + txtRoomNo.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    MessageBox.Show("Data updated Properly");

                    this.PopulateGridView();

                    this.ClearContent();

                }

                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured: " + exc.Message);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Class_Detais where ID = '" + this.txtSearch.Text + "';";
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

        private void dgvUpdateClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateClass.SelectedRows != null && dgvUpdateClass.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateClass.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvUpdateClass.CurrentRow.Cells[1].Value.ToString();

                string No_Of_Students = dgvUpdateClass.CurrentRow.Cells[2].Value.ToString();

                string No_Of_Chairs = dgvUpdateClass.CurrentRow.Cells[3].Value.ToString();

                string No_Of_Table = dgvUpdateClass.CurrentRow.Cells[4].Value.ToString();

                string Section = dgvUpdateClass.CurrentRow.Cells[5].Value.ToString();

                string Room_No = dgvUpdateClass.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtNoOfStudent.Text = No_Of_Students;

                txtNoOfChairs.Text = No_Of_Chairs;

                txtNoOfTables.Text = No_Of_Table;

                txtSection.Text = Section;

                txtRoomNo.Text = Room_No;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
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
