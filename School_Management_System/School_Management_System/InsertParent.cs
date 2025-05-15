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
    public partial class InsertParent : Form
    {
        private DataAccess Da { get; set; }
        public InsertParent()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from ParentDetails;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvInsertParent.DataSource = ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtEmail.Clear();
            this.txtCellNo.Clear();
            this.txtOccupation.Clear();
            this.txtMonthlyIncome.Clear();
            this.txtStatus.Clear();

            this.txtSearch.Clear();
            this.dgvInsertParent.ClearSelection();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtEmail.Text)
                || String.IsNullOrEmpty(this.txtCellNo.Text)
                || String.IsNullOrEmpty(this.txtOccupation.Text) 
                || String.IsNullOrEmpty(this.txtMonthlyIncome.Text)
                || String.IsNullOrEmpty(this.txtStatus.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from ParentDetails where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO ParentDetails (Name, ID, Email, CellNo, Occupation, MonthlyIncome, Status)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtEmail.Text + "', '" + txtCellNo.Text + "', '" + txtOccupation.Text + "', '" + txtMonthlyIncome.Text + "', '" + txtStatus.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Parent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            string sql = "select * from ParentDetails where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ParentDetails where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvInsertParent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertParent.SelectedRows != null && dgvInsertParent.SelectedRows.Count > 0)

            {
                string Name = dgvInsertParent.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertParent.CurrentRow.Cells[1].Value.ToString();

                string Email = dgvInsertParent.CurrentRow.Cells[2].Value.ToString();

                string CellNo = dgvInsertParent.CurrentRow.Cells[3].Value.ToString();

                string Occupation = dgvInsertParent.CurrentRow.Cells[4].Value.ToString();

                string MonthlyIncome = dgvInsertParent.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvInsertParent.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtEmail.Text = Email;

                txtCellNo.Text = CellNo;

                txtOccupation.Text = Occupation;

                txtMonthlyIncome.Text = MonthlyIncome;

                txtStatus.Text = Status;



            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Parent_Details p = new Parent_Details();
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
