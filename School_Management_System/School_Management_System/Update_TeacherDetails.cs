using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Update_TeacherDetails : Form
    {

        private DataAccess Da { get; set; }
        public object JoinDaate { get; private set; }

        public Update_TeacherDetails()
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
            this.dgvUpdateTeacherDetails.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtSubject.Clear();
            this.DOBDate.Value = DateTime.Now;
            this.txtQualification.Clear();
            this.txtCellNo.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvUpdateTeacherDetails.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtSubject.Text)
                || String.IsNullOrEmpty(this.txtQualification.Text)
                || String.IsNullOrEmpty(this.txtCellNo.Text) || String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateTeacherDetails.SelectedRows.Count < 1)
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
                    var query = "UPDATE Teacher_Details SET Name = '" + txtName.Text + "',Subject = '" + txtSubject.Text + "',DOB = '" + DOBDate.Value + "',Qualification = '" + txtQualification.Text + "',CellNo = '" + txtCellNo.Text + "',Description = '" + txtDescription.Text + "'WHERE ID = '" + txtID.Text + "'; ";

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

        private void dgvUpdateTeacherDetails_SelectionChanged(object sender, EventArgs e)
        {
            {
                if (dgvUpdateTeacherDetails.SelectedRows != null && dgvUpdateTeacherDetails.SelectedRows.Count > 0)

                {
                    string Name = dgvUpdateTeacherDetails.CurrentRow.Cells[0].Value.ToString();

                    string ID = dgvUpdateTeacherDetails.CurrentRow.Cells[1].Value.ToString();

                    string Subject = dgvUpdateTeacherDetails.CurrentRow.Cells[2].Value.ToString();

                    string DOB = dgvUpdateTeacherDetails.CurrentRow.Cells[3].Value.ToString();

                    string Qualification = dgvUpdateTeacherDetails.CurrentRow.Cells[4].Value.ToString();

                    string CellNo = dgvUpdateTeacherDetails.CurrentRow.Cells[5].Value.ToString();

                    string Description = dgvUpdateTeacherDetails.CurrentRow.Cells[6].Value.ToString();


                    txtName.Text = Name;

                    txtID.Text = ID;

                    txtSubject.Text = Subject;

                    DOBDate.Text = DOB;

                    txtQualification.Text = Qualification;

                    txtCellNo.Text = CellNo;

                    txtDescription.Text = Description;

                }
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
