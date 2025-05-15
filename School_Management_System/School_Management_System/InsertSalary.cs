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
    public partial class InsertSalary : Form
    {
        private DataAccess Da { get; set; }
        public InsertSalary()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Salary;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvInsertSalary.DataSource = ds.Tables[0];
        }
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtBasic.Clear();
            this.txtOthers.Clear();
            this.txtTotal.Clear();

            this.txtSearch.Clear();
            this.dgvInsertSalary.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtBasic.Text)
                || String.IsNullOrEmpty(this.txtOthers.Text)
                || String.IsNullOrEmpty(this.txtTotal.Text))

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from Salary where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO Salary (Name, ID, Basic, Others,Total)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtBasic.Text + "', '" + txtOthers.Text + "', '" + txtTotal.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Salary?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            string sql = "select * from Salary where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Salary where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvInsertSalary_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertSalary.SelectedRows != null && dgvInsertSalary.SelectedRows.Count > 0)

            {
                string Name = dgvInsertSalary.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertSalary.CurrentRow.Cells[1].Value.ToString();

                string Basic = dgvInsertSalary.CurrentRow.Cells[2].Value.ToString();

                string Others = dgvInsertSalary.CurrentRow.Cells[3].Value.ToString();

                string Total = dgvInsertSalary.CurrentRow.Cells[4].Value.ToString();



                txtName.Text = Name;

                txtID.Text = ID;

                txtBasic.Text = Basic;

                txtOthers.Text = Others;

                txtTotal.Text = Total;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
