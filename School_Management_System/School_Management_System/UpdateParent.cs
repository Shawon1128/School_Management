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
    public partial class UpdateParent : Form
    {
        private DataAccess Da { get; set; }
        public UpdateParent()
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
            this.dgvUpdateParent.DataSource = ds.Tables[0];
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
            this.dgvUpdateParent.ClearSelection();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtID.Text) ||
                String.IsNullOrEmpty(this.txtEmail.Text)
                || String.IsNullOrEmpty(this.txtCellNo.Text)
                || String.IsNullOrEmpty(this.txtOccupation.Text)
                || String.IsNullOrEmpty(this.txtMonthlyIncome.Text)
                || String.IsNullOrEmpty(this.txtStatus.Text))

            {
                MessageBox.Show("Fields are blank!  Plaese select a Row first to Update");
            }

            else
            {
                if (this.dgvUpdateParent.SelectedRows.Count < 1)
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
                    var query = "UPDATE ParentDetails SET Name = '" + txtName.Text + "',Email = '" + txtEmail.Text + "',CellNo = '" + txtCellNo.Text + "',Occupation = '" + txtOccupation.Text + "',MonthlyIncome = '" + txtMonthlyIncome.Text + "',Status = '" + txtStatus.Text+  "'WHERE ID = '" + txtID.Text + "'; ";

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

        private void dgvUpdateParent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateParent.SelectedRows != null && dgvUpdateParent.SelectedRows.Count > 0)

            {
                string Name = dgvUpdateParent.CurrentRow.Cells[0].Value.ToString();

                string ID = dgvUpdateParent.CurrentRow.Cells[1].Value.ToString();

                string Email = dgvUpdateParent.CurrentRow.Cells[2].Value.ToString();

                string CellNo = dgvUpdateParent.CurrentRow.Cells[3].Value.ToString();

                string Occupation = dgvUpdateParent.CurrentRow.Cells[4].Value.ToString();

                string MonthlyIncome = dgvUpdateParent.CurrentRow.Cells[5].Value.ToString();

                string Status = dgvUpdateParent.CurrentRow.Cells[6].Value.ToString();


                txtName.Text = Name;

                txtID.Text = ID;

                txtEmail.Text = Email;

                txtCellNo.Text = CellNo;

                txtOccupation.Text = Occupation;

                txtMonthlyIncome.Text = MonthlyIncome;

                txtStatus.Text = Status;



            }
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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
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
