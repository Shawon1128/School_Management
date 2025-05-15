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
    public partial class InsertEmployeeDetails : Form
    {
        private DataAccess Da { get; set; }
        public InsertEmployeeDetails()
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
            this.dgvInsertEmployeeDetails.DataSource = ds.Tables[0];
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
            this.dgvInsertEmployeeDetails.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtCNO.Text)
                || String.IsNullOrEmpty(this.txtGender.Text)
                || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtStatus.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from EmployeeDetails where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO EmployeeDetails (Name, ID, CellNo, DOB, Gender, Address, Status)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtCNO.Text + "', '" + DOBDate.Value + "', '" + txtGender.Text + "', '" + txtAddress.Text + "', '" + txtStatus.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (d == DialogResult.No)

                            return;

                        int a = Da.ExecuteDMLQuery(sql);

                        if (a > 0)
                        {
                            MessageBox.Show("Successfully added!");

                            this.PopulateGridView();

                            //this.ClearContent();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add");
                        }
                    }
                    this.PopulateGridView();
                    this.ClearContent();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured!", ex.Message);
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

        private void dgvInsertEmployeeDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertEmployeeDetails.SelectedRows != null && dgvInsertEmployeeDetails.SelectedRows.Count > 0)

            {
                string Name = dgvInsertEmployeeDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertEmployeeDetails.CurrentRow.Cells[1].Value.ToString();

                string CellNo = dgvInsertEmployeeDetails.CurrentRow.Cells[2].Value.ToString();

                string DOB = dgvInsertEmployeeDetails.CurrentRow.Cells[3].Value.ToString();

                string Gender = dgvInsertEmployeeDetails.CurrentRow.Cells[4].Value.ToString();

                string Address = dgvInsertEmployeeDetails.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvInsertEmployeeDetails.CurrentRow.Cells[6].Value.ToString();


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
