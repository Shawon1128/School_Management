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
    public partial class UpdateSubjectDetails : Form
    {
        private DataAccess Da { get; set; }
        public UpdateSubjectDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from SubjectDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvUpdateSubjectDetails.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtClass.Clear();
            this.txtAuthor.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvUpdateSubjectDetails.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtClass.Text) ||
                String.IsNullOrEmpty(this.txtAuthor.Text)
                || String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateSubjectDetails.SelectedRows.Count < 1)
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
                    var query = "UPDATE SubjectDetails SET Class = '" + txtClass.Text + "',Author = '" + txtAuthor.Text + "',Description = '" + txtDescription.Text + "'WHERE Name = '" + txtName.Text + "'; ";

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
                string sql = "select * from SubjectDetails where Name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An exception has occured!", exc.Message);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from SubjectDetails where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvUpdateSubjectDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateSubjectDetails.SelectedRows != null && dgvUpdateSubjectDetails.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateSubjectDetails.CurrentRow.Cells[0].Value.ToString();

                string Class = dgvUpdateSubjectDetails.CurrentRow.Cells[1].Value.ToString();

                string Author = dgvUpdateSubjectDetails.CurrentRow.Cells[2].Value.ToString();

                string Description = dgvUpdateSubjectDetails.CurrentRow.Cells[3].Value.ToString();


                txtName.Text = Name;

                txtClass.Text = Class;

                txtAuthor.Text = Author;

                txtDescription.Text = Description;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Subject_Details s = new Subject_Details();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
