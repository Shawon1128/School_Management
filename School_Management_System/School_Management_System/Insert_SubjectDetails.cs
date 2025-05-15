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
    public partial class Insert_SubjectDetails : Form
    {
        private DataAccess Da { get; set; }
        public Insert_SubjectDetails()
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
            this.dgvInsertSubjectDetails.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtClass.Clear();
            this.txtAuthor.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvInsertSubjectDetails.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtClass.Text) ||
                String.IsNullOrEmpty(this.txtAuthor.Text)
                || String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from SubjectDetails where Name = '" + txtName.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO SubjectDetails (Name, Class, Author, Description)VALUES('" + txtName.Text + "','" + txtClass.Text + "', '" + txtAuthor.Text + "', '" + txtDescription.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void dgvInsertSubjectDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertSubjectDetails.SelectedRows != null && dgvInsertSubjectDetails.SelectedRows.Count > 0)

            {
                string Name = dgvInsertSubjectDetails.CurrentRow.Cells[0].Value.ToString();

                string Class = dgvInsertSubjectDetails.CurrentRow.Cells[1].Value.ToString();

                string Author = dgvInsertSubjectDetails.CurrentRow.Cells[2].Value.ToString();

                string Description = dgvInsertSubjectDetails.CurrentRow.Cells[3].Value.ToString();


                txtName.Text = Name;

                txtClass.Text = Class;

                txtAuthor.Text = Author;

                txtDescription.Text = Description;

            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from SubjectDetails where Name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("An exception has occured!", exc.Message);
            }
            
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from SubjectDetails where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
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
