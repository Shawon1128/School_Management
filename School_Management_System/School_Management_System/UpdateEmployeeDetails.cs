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
    public partial class UpdateEmployeeDetails : Form
    {
        private DataAccess Da { get; set; }
        public UpdateEmployeeDetails()
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
            this.dgvUpdateEmployeeDetails.DataSource = ds.Tables[0];
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
            this.dgvUpdateEmployeeDetails.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtCNO.Text)
                || String.IsNullOrEmpty(this.txtGender.Text)
                || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtStatus.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateEmployeeDetails.SelectedRows.Count < 1)
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
                    var query = "UPDATE EmployeeDetails SET Name = '" + txtName.Text + "',CellNo = '" + txtCNO.Text + "',DOB = '" + DOBDate.Value + "',Gender = '" + txtGender.Text + "',Address = '" + txtAddress.Text + "',Status = '" + txtStatus.Text + "'WHERE ID = '" + txtID.Text + "'; ";

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

        private void dgvUpdateEmployeeDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateEmployeeDetails.SelectedRows != null && dgvUpdateEmployeeDetails.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateEmployeeDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvUpdateEmployeeDetails.CurrentRow.Cells[1].Value.ToString();

                string CellNo = dgvUpdateEmployeeDetails.CurrentRow.Cells[2].Value.ToString();

                string DOB = dgvUpdateEmployeeDetails.CurrentRow.Cells[3].Value.ToString();

                string Gender = dgvUpdateEmployeeDetails.CurrentRow.Cells[4].Value.ToString();

                string Address = dgvUpdateEmployeeDetails.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvUpdateEmployeeDetails.CurrentRow.Cells[6].Value.ToString();


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
