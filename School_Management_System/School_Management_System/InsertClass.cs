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
    public partial class InsertClass : Form
    {
        private DataAccess Da { get; set; }
        public InsertClass()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Class_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvInsertClass.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtNoOfStudents.Clear();
            this.txtNoOfChairs.Clear();
            this.txtNoOfTables.Clear();
            this.txtSection.Clear();
            this.txtRoomNo.Clear();

            this.txtSearch.Clear();
            this.dgvInsertClass.ClearSelection();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtNoOfStudents.Text)
                || String.IsNullOrEmpty(this.txtNoOfChairs.Text)
                || String.IsNullOrEmpty(this.txtNoOfTables.Text) || 
                String.IsNullOrEmpty(this.txtSection.Text)|| String.IsNullOrEmpty(this.txtRoomNo.Text) )

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from Class_Details where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO Class_Details (Name, ID, No_Of_Students, No_Of_Chairs ,No_Of_Tables, Section, Room_No)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtNoOfStudents.Text + "', '" + txtNoOfChairs.Text + "', '" + txtNoOfTables.Text + "', '" + txtSection.Text + "', '" + txtRoomNo.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void dgvInsertClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertClass.SelectedRows != null && dgvInsertClass.SelectedRows.Count > 0)

            {
                string Name = dgvInsertClass.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertClass.CurrentRow.Cells[1].Value.ToString();

                string No_Of_Students = dgvInsertClass.CurrentRow.Cells[2].Value.ToString();

                string No_Of_Chairs = dgvInsertClass.CurrentRow.Cells[3].Value.ToString();

                string No_Of_Table = dgvInsertClass.CurrentRow.Cells[4].Value.ToString();

                string Section = dgvInsertClass.CurrentRow.Cells[5].Value.ToString();

                string Room_No = dgvInsertClass.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtNoOfStudents.Text = No_Of_Students;

                txtNoOfChairs.Text = No_Of_Chairs;

                txtNoOfTables.Text = No_Of_Table;

                txtSection.Text = Section;

                txtRoomNo.Text = Room_No;
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
                string sql = "select * from Class_Details where ID = '" + this.txtSearch.Text + "';";
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
                string sql = "select * from Class_Details where Name like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured!", exc.Message);
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Class_Details c = new Class_Details();
            c.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
