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
    public partial class InsertStudentDetails : Form
    {
        private DataAccess Da { get; set; }
        public InsertStudentDetails()
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
            this.dgvInsertStudentDetails.DataSource = ds.Tables[0];
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
            this.dgvInsertStudentDetails.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtClass.Text)
                || String.IsNullOrEmpty(this.txtStatus.Text)
                || String.IsNullOrEmpty(this.txtCellNo.Text) || String.IsNullOrEmpty(this.txtParentCellNo.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from Student_Details where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO Student_Details (Name, ID, Class, Address,DOB, Admission_Date, Status, Cell_No, Parent_Cell_No)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtClass.Text + "', '" + txtAddress.Text + "', '" + DOBDate.Value + "', '" + AdmissionDate.Value + "', '" + txtStatus.Text + "', '" + txtCellNo.Text + "', '" + txtParentCellNo.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void dgvInsertStudentDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertStudentDetails.SelectedRows != null && dgvInsertStudentDetails.SelectedRows.Count > 0)

            {
                string Name = dgvInsertStudentDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertStudentDetails.CurrentRow.Cells[1].Value.ToString();

                string Class = dgvInsertStudentDetails.CurrentRow.Cells[2].Value.ToString();

                string Address = dgvInsertStudentDetails.CurrentRow.Cells[3].Value.ToString();

                string DOB = dgvInsertStudentDetails.CurrentRow.Cells[4].Value.ToString();

                string Admission_Date = dgvInsertStudentDetails.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvInsertStudentDetails.CurrentRow.Cells[6].Value.ToString();

                string Cell_No = dgvInsertStudentDetails.CurrentRow.Cells[7].Value.ToString();

                string Parent_Cell_No = dgvInsertStudentDetails.CurrentRow.Cells[8].Value.ToString();


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
