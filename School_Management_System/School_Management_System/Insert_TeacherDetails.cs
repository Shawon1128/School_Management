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
    public partial class Insert_TeacherDetails : Form
    {
        private DataAccess Da { get; set; }
        //public object JoinDate { get; private set; }

        public Insert_TeacherDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Teacher_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvInsertTeacherDetails.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
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
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtSubject.Clear();
            this.DOBDate.Value = DateTime.Now;
            this.txtQualification.Clear();
            this.txtCellNO.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            //this.dgvInsertTeacherDetails.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtSubject.Text)
                || String.IsNullOrEmpty(this.txtQualification.Text)
                || String.IsNullOrEmpty(this.txtCellNO.Text) || String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from Teacher_Details where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO Teacher_Details (Name, ID, Subject, DOB, Qualification, CellNo, Description)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtSubject.Text + "', '" + DOBDate.Value + "', '" + txtQualification.Text + "', '" + txtCellNO.Text + "', '" + txtDescription.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (d == DialogResult.No)

                            return;

                        int a = Da.ExecuteDMLQuery(sql);

                        if (a > 0)
                        {
                            MessageBox.Show("Successfully added!");

                            this.PopulateGridView();

                            this.ClearContent();
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

        private void dgvInsertTeacherDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertTeacherDetails.SelectedRows != null && dgvInsertTeacherDetails.SelectedRows.Count > 0)

            {
                string Name = dgvInsertTeacherDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertTeacherDetails.CurrentRow.Cells[1].Value.ToString();

                string Subject = dgvInsertTeacherDetails.CurrentRow.Cells[2].Value.ToString();

                string DOB = dgvInsertTeacherDetails.CurrentRow.Cells[3].Value.ToString();

                string Qualification = dgvInsertTeacherDetails.CurrentRow.Cells[4].Value.ToString();

                string CellNo = dgvInsertTeacherDetails.CurrentRow.Cells[5].Value.ToString();

                string Description = dgvInsertTeacherDetails.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtSubject.Text = Subject;

                DOBDate.Text = DOB;

                txtQualification.Text = Qualification;

                txtCellNO.Text = CellNo;

                txtDescription.Text = Description;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Teacher_Details t = new Teacher_Details();
            t.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
