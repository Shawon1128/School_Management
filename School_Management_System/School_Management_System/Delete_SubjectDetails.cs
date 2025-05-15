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
    public partial class Delete_SubjectDetails : Form
    {
        private DataAccess Da { get; set; }
        public Delete_SubjectDetails()
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
            this.dgvDeleteSubjectDetails.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtClass.Clear();
            this.txtAuthor.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvDeleteSubjectDetails.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteSubjectDetails.SelectedRows.Count < 1)

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

                var query = "delete from SubjectDetails where Name = '" + txtName.Text + "';";

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
                string sql = "select * from SubjectDetails where Name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An exception has occured!", exc.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from SubjectDetails where Name like '" + this.txtAutoSearch.Text + "%';";
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

        private void dgvDeleteSubjectDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteSubjectDetails.SelectedRows != null && dgvDeleteSubjectDetails.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteSubjectDetails.CurrentRow.Cells[0].Value.ToString();

                string Class = dgvDeleteSubjectDetails.CurrentRow.Cells[1].Value.ToString();

                string Author = dgvDeleteSubjectDetails.CurrentRow.Cells[2].Value.ToString();

                string Description = dgvDeleteSubjectDetails.CurrentRow.Cells[3].Value.ToString();


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

        private void Delete_SubjectDetails_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
