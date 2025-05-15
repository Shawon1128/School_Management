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
    public partial class InsertExpenseDetails : Form
    {
        private DataAccess Da { get; set; }
        public InsertExpenseDetails()
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
            this.dgvInsertExpenseDetails.DataSource = ds.Tables[0];
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
            this.dgvInsertExpenseDetails.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtExpenseType.Text)
                || String.IsNullOrEmpty(this.txtAmount.Text)
                || String.IsNullOrEmpty(this.txtDescription.Text) )

            {
                MessageBox.Show("Fields are blank!");
            }
            else

            {
                try

                {
                    string sqlSelect = "select * from Expense_Details where ID = '" + txtID.Text + "';";

                    Da.ExecuteQueryTable(sqlSelect);


                    if (Da.Ds.Tables[0].Rows.Count > 0)

                    {
                        MessageBox.Show("Item already exists");
                    }

                    else

                    {
                        string sql = "INSERT INTO Expense_Details (Name, ID, ExpenseType, Date, Amount, Description)VALUES('" + txtName.Text + "', '" + txtID.Text + "', '" + txtExpenseType.Text + "','" + txtDate.Value + "','" + txtAmount.Text + "', '" + txtDescription.Text + "'); ";

                        DialogResult d = MessageBox.Show("Are you sure want to add Expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void dgvInsertExpenseDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInsertExpenseDetails.SelectedRows != null && dgvInsertExpenseDetails.SelectedRows.Count > 0)

            {
                string Name = dgvInsertExpenseDetails.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvInsertExpenseDetails.CurrentRow.Cells[1].Value.ToString();

                string ExpenseType = dgvInsertExpenseDetails.CurrentRow.Cells[2].Value.ToString();

                string Date = dgvInsertExpenseDetails.CurrentRow.Cells[3].Value.ToString();

                string Amount = dgvInsertExpenseDetails.CurrentRow.Cells[4].Value.ToString();

                string Description = dgvInsertExpenseDetails.CurrentRow.Cells[5].Value.ToString();


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
