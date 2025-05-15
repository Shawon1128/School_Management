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
    public partial class DeleteEmployeeDetails : Form
    {
        private DataAccess Da { get; set; }
        public DeleteEmployeeDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from EmployeeDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvDeleteEmployeeDetails.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtCNO.Clear();
            this.DOBDate.Value = DateTime.Now;
            this.txtGender.Clear();
            this.txtAddress.Clear();
            this.txtStatus.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteEmployeeDetails.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteEmployeeDetails.SelectedRows.Count < 1)

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

                var query = "delete from EmployeeDetails where ID = '" + txtID.Text + "';";

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
                string sql = "select * from EmployeeDetails where ID = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
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
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvDeleteEmployeeDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteEmployeeDetails.SelectedRows != null && dgvDeleteEmployeeDetails.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteEmployeeDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteEmployeeDetails.CurrentRow.Cells[1].Value.ToString();

                string CellNo = dgvDeleteEmployeeDetails.CurrentRow.Cells[2].Value.ToString();

                string DOB = dgvDeleteEmployeeDetails.CurrentRow.Cells[3].Value.ToString();

                string Gender = dgvDeleteEmployeeDetails.CurrentRow.Cells[4].Value.ToString();

                string Address = dgvDeleteEmployeeDetails.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvDeleteEmployeeDetails.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtCNO.Text = CellNo;

                DOBDate.Text = DOB;

                txtGender.Text = Gender;

                txtAddress.Text = Address;

                txtStatus.Text = Status;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Employee_Details ed = new Employee_Details();
            ed.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
