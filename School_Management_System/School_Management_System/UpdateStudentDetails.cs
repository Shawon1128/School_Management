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
    public partial class UpdateStudentDetails : Form
    {
        private DataAccess Da { get; set; }
        public UpdateStudentDetails()
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
            this.dgvUpdateStudentDetails.DataSource = ds.Tables[0];
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
            this.dgvUpdateStudentDetails.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtClass.Text)
                || String.IsNullOrEmpty(this.txtStatus.Text)
                || String.IsNullOrEmpty(this.txtCellNo.Text) || String.IsNullOrEmpty(this.txtParentCellNo.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateStudentDetails.SelectedRows.Count < 1)
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
                    var query = "UPDATE Student_Details SET Name = '" + txtName.Text + "',Class = '" + txtClass.Text + "',Address = '" + txtAddress.Text + "',DOB = '" + DOBDate.Value + "',Admission_Date = '" + AdmissionDate.Value + "',Status = '" + txtStatus.Text + "',Cell_No = '" + txtCellNo.Text + "',Parent_Cell_No = '" + txtParentCellNo.Text + "'WHERE ID = '" + txtID.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    MessageBox.Show("Data updated Properly");

                    this.PopulateGridView();

                    //this.ClearContent();

                }

                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured: " + exc.Message);
                }

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

        private void dgvUpdateStudentDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateStudentDetails.SelectedRows != null && dgvUpdateStudentDetails.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateStudentDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvUpdateStudentDetails.CurrentRow.Cells[1].Value.ToString();

                string Class = dgvUpdateStudentDetails.CurrentRow.Cells[2].Value.ToString();

                string Address = dgvUpdateStudentDetails.CurrentRow.Cells[3].Value.ToString();

                string DOB = dgvUpdateStudentDetails.CurrentRow.Cells[4].Value.ToString();

                string Admission_Date = dgvUpdateStudentDetails.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvUpdateStudentDetails.CurrentRow.Cells[6].Value.ToString();

                string Cell_No = dgvUpdateStudentDetails.CurrentRow.Cells[7].Value.ToString();

                string Parent_Cell_No = dgvUpdateStudentDetails.CurrentRow.Cells[8].Value.ToString();


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
