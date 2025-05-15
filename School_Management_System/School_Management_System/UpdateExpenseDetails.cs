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
    public partial class UpdateExpenseDetails : Form
    {
        private DataAccess Da { get; set; }
        public UpdateExpenseDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.PopulateGridView();
            this.ClearContent();
        }

        private void PopulateGridView(string sql = "select * from Expense_Details;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvClassDetails.AutoGenerateColumns = false;
            this.dgvUpdateExpenseDetails.DataSource = ds.Tables[0];
        }

        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtID.Clear();
            this.txtExpenseType.Clear();
            this.txtDate.Value = DateTime.Now;
            this.txtAmount.Clear();
            this.txtDescription.Clear();

            this.txtSearch.Clear();
            this.dgvUpdateExpenseDetails.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtExpenseType.Text)
                || String.IsNullOrEmpty(this.txtAmount.Text)
                || String.IsNullOrEmpty(this.txtDescription.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateExpenseDetails.SelectedRows.Count < 1)
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
                    var query = "UPDATE Expense_Details SET Name = '" + txtName.Text + "',ExpenseType = '" + txtExpenseType.Text + "',Date = '" + txtDate.Value + "',Amount = '" + txtAmount.Text + "',Description = '" + txtDescription.Text + "'WHERE ID = '" + txtID.Text + "'; ";

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
            string sql = "select * from Expense_Details where ID = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Expense_Details where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvUpdateExpenseDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateExpenseDetails.SelectedRows != null && dgvUpdateExpenseDetails.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateExpenseDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvUpdateExpenseDetails.CurrentRow.Cells[1].Value.ToString();

                string ExpenseType = dgvUpdateExpenseDetails.CurrentRow.Cells[2].Value.ToString();

                string Date = dgvUpdateExpenseDetails.CurrentRow.Cells[3].Value.ToString();

                string Amount = dgvUpdateExpenseDetails.CurrentRow.Cells[4].Value.ToString();

                string Description = dgvUpdateExpenseDetails.CurrentRow.Cells[5].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtExpenseType.Text = ExpenseType;

                txtDate.Text = Date;

                txtAmount.Text = Amount;

                txtDescription.Text = Description;

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Expense_Details es = new Expense_Details();
            es.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
