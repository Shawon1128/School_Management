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
    public partial class DeleteStudentDetails : Form
    {
        private DataAccess Da { get; set; }
        public DeleteStudentDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Student_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvDeleteStudentDetails.DataSource = ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtClass.Clear();
            this.txtAddress.Clear();
            this.DOBDate.Value = DateTime.Now;
            this.AdmissionDate.Value = DateTime.Now;
            this.txtStatus.Clear();
            this.txtCellNo.Clear();
            this.txtParentCellNo.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteStudentDetails.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteStudentDetails.SelectedRows.Count < 1)

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

                var query = "delete from Student_Details where ID = '" + txtID.Text + "';";

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
            string sql = "select * from Student_Details where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Student_Details where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvDeleteStudentDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteStudentDetails.SelectedRows != null && dgvDeleteStudentDetails.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteStudentDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteStudentDetails.CurrentRow.Cells[1].Value.ToString();

                string Class = dgvDeleteStudentDetails.CurrentRow.Cells[2].Value.ToString();

                string Address = dgvDeleteStudentDetails.CurrentRow.Cells[3].Value.ToString();

                string DOB = dgvDeleteStudentDetails.CurrentRow.Cells[4].Value.ToString();

                string Admission_Date = dgvDeleteStudentDetails.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvDeleteStudentDetails.CurrentRow.Cells[6].Value.ToString();

                string Cell_No = dgvDeleteStudentDetails.CurrentRow.Cells[7].Value.ToString();

                string Parent_Cell_No = dgvDeleteStudentDetails.CurrentRow.Cells[8].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtClass.Text = Class;

                txtAddress.Text = Address;

                DOBDate.Text = DOB;

                AdmissionDate.Text = Admission_Date;

                txtStatus.Text = Status;

                txtCellNo.Text = Cell_No;

                txtParentCellNo.Text = Parent_Cell_No;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            StudentDetails s = new StudentDetails();
            s.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
