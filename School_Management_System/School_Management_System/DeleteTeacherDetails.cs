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
    public partial class DeleteTeacherDetails : Form
    {
        private DataAccess Da { get; set; }
        //public object JoinDate { get; private set; }

        public DeleteTeacherDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtSubject.Clear();
            this.DOBDate.Value = DateTime.Now;
            this.txtCellNo.Clear();
            this.txtQualification.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteTeacherDetails.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from Teacher_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvDeleteTeacherDetails.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteTeacherDetails.SelectedRows.Count < 1)

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

                var query = "delete from Teacher_Details where ID = '" + txtID.Text + "';";

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
            string sql = "select * from Teacher_Details where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Teacher_Details where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvDeleteTeacherDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteTeacherDetails.SelectedRows != null && dgvDeleteTeacherDetails.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteTeacherDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteTeacherDetails.CurrentRow.Cells[1].Value.ToString();

                string Subject = dgvDeleteTeacherDetails.CurrentRow.Cells[2].Value.ToString();

                string DOB = dgvDeleteTeacherDetails.CurrentRow.Cells[3].Value.ToString();

                

                string Qualification = dgvDeleteTeacherDetails.CurrentRow.Cells[4].Value.ToString();

                string CellNo = dgvDeleteTeacherDetails.CurrentRow.Cells[5].Value.ToString();

                string Description = dgvDeleteTeacherDetails.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtSubject.Text = Subject;

                DOBDate.Text = DOB;

                

                txtQualification.Text = Qualification;

                txtCellNo.Text = CellNo;

                txtDescription.Text = Description;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Teacher_Details t = new Teacher_Details();
            t.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
