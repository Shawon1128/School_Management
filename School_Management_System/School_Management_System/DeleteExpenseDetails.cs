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
    public partial class DeleteExpenseDetails : Form
    {
        private DataAccess Da { get; set; }
        public DeleteExpenseDetails()
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
            this.dgvDeleteExpenseDetails.DataSource = ds.Tables[0];
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
            this.dgvDeleteExpenseDetails.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDeleteExpenseDetails.SelectedRows.Count < 1)

            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    //MessageBox.Show("No delete");
                    return;
                }

                var query = "delete from Expense_Details where ID = '" + txtID.Text + "';";

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

        private void dgvDeleteExpenseDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeleteExpenseDetails.SelectedRows != null && dgvDeleteExpenseDetails.SelectedRows.Count > 0)

            {
                string Name = dgvDeleteExpenseDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvDeleteExpenseDetails.CurrentRow.Cells[1].Value.ToString();

                string ExpenseType = dgvDeleteExpenseDetails.CurrentRow.Cells[2].Value.ToString();

                string Date = dgvDeleteExpenseDetails.CurrentRow.Cells[3].Value.ToString();

                string Amount = dgvDeleteExpenseDetails.CurrentRow.Cells[4].Value.ToString();

                string Description = dgvDeleteExpenseDetails.CurrentRow.Cells[5].Value.ToString();


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
            Expense_Details exp = new Expense_Details();
            exp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
